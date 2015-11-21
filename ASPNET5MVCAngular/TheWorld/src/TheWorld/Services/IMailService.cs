using System;

namespace TheWorld.Services
{
    interface IMailService
    {
        bool SendMail(string to, string from, string subject, string body);
    }
}
