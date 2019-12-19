using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Message
    {
        private string _data { get; set; }
        private string _senderName { get; set; }
        private DateTime _timeSent { get; set; }

        public Message(string data, string senderName, DateTime timeSent)
        {
            _data = data;
            _senderName = senderName;
            _timeSent = timeSent;
        }

        public string GetData()
        {
            return _data;
        }

        public string GetSenderName()
        {
            return _senderName;
        }

        public DateTime GetTimeSent()
        {
            return _timeSent;
        }
    }
}
