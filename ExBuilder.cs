using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics
{
    public class BankAccount
    {
        public string userName { get; set; }
        public string userAdhar { get; set; }
        public string userPan { get; set; }
        public string userEmail { get; set; }
        public byte[] userPhoto { get; set; }
    

        public BankAccount(string name, string adhar, string pan, string email, byte[] photo)
        {
            userName = name;
            userAdhar = adhar;
            userPan = pan;
            userEmail = email;
            userPhoto = photo;
        }
    }

    public class BankAccountBuilder
    {
        private string _username;
        private string _useradhar;
        private string _userpan;
        private string _useremail;
        private byte[] _userphoto;

        public BankAccountBuilder WithuserName(string name)
        {
            _username = name;
            return this;
        }

        public BankAccountBuilder WithuserAdhar(string adhar)
        {
            _useradhar = adhar;
            return this;
        }

        public BankAccountBuilder WithuserPan(string pan)
        {
            _userpan = pan;
            return this;
        }

        public BankAccountBuilder WithuserEmail(string email)
        {
            _useremail = email;
            return this;
        }

        public BankAccountBuilder WithuserPhoto(byte[] photo)
        {
            _userphoto = photo;
            return this;
        }

        public BankAccount Build()
        {
            return new BankAccount(_username, _useradhar, _userpan, _useremail, _userphoto);
        }
    }

    internal class ExBuilder
    {
        private static void Main(string[] args)
        {
            var photo = new byte[] { 0x12, 0x34, 0x56, 0x78 };
            var obj = new BankAccountBuilder()
                .WithuserName("canarabank")
                .WithuserAdhar("65222288123452")
                .WithuserPan("PAN0123456")
                .WithuserEmail("akshasrinivas888@gmail.com")
                .WithuserPhoto(photo)
                .Build();

            Console.WriteLine("Name: " + obj.userName);
            Console.WriteLine("Adhar: " + obj.userAdhar);
            Console.WriteLine("PAN: " + obj.userPan);
            Console.WriteLine("Email: " + obj.userEmail);
            Console.WriteLine("Photo size: " + obj.userPhoto.Length);
        }
    }
}

