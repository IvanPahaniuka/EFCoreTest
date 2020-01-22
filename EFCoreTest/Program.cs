using System;
using System.Linq;

namespace EFCoreTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Console.Write("Введите сообщение: ");
                string text = Console.ReadLine();
                while (text != "exit")
                {
                    Message message = new Message { Text = text };
                    db.Messages.Add(message);

                    Console.Write("Введите сообщение: ");
                    text = Console.ReadLine();
                }
                db.SaveChanges();

                var messages = db.Messages.ToList();
                foreach (Message message in messages)
                    Console.WriteLine($"Message{message.Id}: \n{message.Text}");

            }

            Console.ReadKey();
        }
    }
}
