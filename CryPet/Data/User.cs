﻿using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryPet.Data
{
    public class User
    {
        public int Id { get; set; }
        public byte[] Photo { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; } = 0;

        public void SavePhoto(int userid, PictureBox pcb)
        {
            using (var context = new ConnectDb())
            {

                User user = context.Users.FirstOrDefault(a => a.Id == userid);
                using (MemoryStream ms = new MemoryStream())
                {
                    pcb.Image.Save(ms, pcb.Image.RawFormat);
                    user.Photo = ms.ToArray();
                }

                context.SaveChanges();
            }
        }
        public void DisplayPhoto(int userId, PictureBox pcb)
        {
            using (var context = new ConnectDb())
            {
                User user = context.Users.FirstOrDefault(a => a.Id == userId);
                if (user != null && user.Photo != null)
                {

                    using (MemoryStream ms = new MemoryStream(user.Photo))
                    {
                        pcb.Image = Image.FromStream(ms);
                    }
                }
            }
        }
        public async Task<(string lastname, string balance)> FillMiniProfile(int userId)
        {
            using (ConnectDb db = new ConnectDb())
            {
                User user = await Task.Run(() => db.Users.FirstOrDefaultAsync(x => x.Id == userId));
                if (user != null)
                {
                    return (user.LastName, user.Balance.ToString());
                }
                return (null, null);
            }
        }
        public async Task UpdateDataUser(int userId, string lastname, string firstname, string middlename)
        {
            using (ConnectDb db = new ConnectDb())
            {
                User user = await db.Users.FirstOrDefaultAsync(a => a.Id == userId);
                if (user != null)
                {
                    user.LastName = lastname;
                    user.FirstName = firstname;
                    user.MiddleName = middlename;
                    await db.SaveChangesAsync();
                    MessageBox.Show("Данные успешно сохранены");
                }

            }
        }
        public async Task<(string lastname,string firstname,string middlename)> LoadDataUser(int userId)
        {
            using(ConnectDb db = new ConnectDb())
            {
                User user = await Task.Run(() => db.Users.FirstOrDefaultAsync(a => a.Id == userId));
                if(user != null)
                {
                    return (user.LastName,user.FirstName,user.MiddleName);
                }
                return (null,null,null);
            }
        }
        public async Task<string> GetUserName(int userId)
        {
            using (ConnectDb db = new ConnectDb())
            {
                User user = await Task.Run(() => db.Users.FirstOrDefaultAsync(a => a.Id == userId));
                if (user != null)
                {
                    return user.LastName;
                }
                return null;
            }
        }
        public async Task<bool> AddUser(string lastName, string firstName, string middleName, string login, string password)
        {
            using (ConnectDb db = new ConnectDb())
            {
                User user = await Task.Run(() => db.Users.FirstOrDefaultAsync(a => a.Login == login));
                if (user != null)
                {
                    MessageBox.Show("Этот логин уже занят", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                db.Users.Add(new User()
                {
                    LastName = lastName,
                    FirstName = firstName,
                    MiddleName = middleName,
                    Login = login,
                    Password = password
                });
                await db.SaveChangesAsync();
                return true;
            }
        }
        public async Task<int?> GetUserId(string login, string password)
        {
            using (ConnectDb db = new ConnectDb())
            {
                User ExistUser = await Task.Run(() => db.Users.FirstOrDefaultAsync(a => a.Login == login && a.Password == password));
                if (ExistUser == null)
                {
                    MessageBox.Show("Неверный логин или пароль", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                return ExistUser.Id;
            }
        }

    }
}
