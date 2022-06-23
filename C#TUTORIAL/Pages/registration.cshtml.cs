using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MySql.EntityFrameworkCore.Extensions;
using System.Text;
using C__TUTORIAL.Models;

namespace C_TUTORIAL.Pages
{
    public class abc : PageModel
    {

        public string Username1 { get; set; }
        public string Password1 { get; set; }
        public string Email1 { get; set; }
        public string Data { get; set; }

        public void OnGet()
        {

        }
         public void OnPostSubmit(registration person)
         {      
            
            
            this.Username1=string.Format("{0}",person.Username);
            this.Password1=string.Format("{0}",person.Password);
            this.Email1=string.Format("{0}",person.Email);

        InsertData(this.Username1,this.Password1,this.Email1);
        this.Data=PrintData();
        }    
        private static void InsertData(string unm,string pass,string mail)
        {   
        using(var con = new Context()) 
        {
            // Creates the database if not exists
            con.Database.EnsureCreated();

            // Adds some books
            con.registration.Add(new registration 
            {
                
                Username=unm,
                Password=pass,
                Email=mail
            }
            );
            con.SaveChanges();
        }
      }
       public static string PrintData()
    {
        string Disp=null;
        // Gets and prints all books in database
        using (var con = new Context())
        {
        
             var books = con.registration;
             foreach(var book in books)
           {
             var data = new StringBuilder();
             data.AppendLine($"User Name: {book.Username}");
             data.AppendLine($"Password: {book.Password}");
             data.AppendLine($"Email: {book.Email}");
             Disp= Disp +data.ToString();
           }
            var Display = Disp;
        
        }
       return Disp;
    }
    }
}
