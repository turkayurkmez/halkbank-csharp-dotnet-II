// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");

MailSender mailSender = new MailSender();
WhatsAppSender whatsSender = new WhatsAppSender();
TelegramSender TelegramSender = new TelegramSender();
Report report = new Report(mailSender);
Report report2 = new Report(whatsSender);
Report report3 = new Report(TelegramSender);



