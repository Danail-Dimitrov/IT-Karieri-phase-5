using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    class Telephone : ICallable, IBrowsable
    {
        private List<string> numbers;
        private List<string> urls;

        public Telephone(string[] numbers, string[] urls)
        {
            this.numbers = new List<string>();
            this.urls = new List<string>();
            Numbers = numbers.ToList();
            Urls = urls.ToList();
        }

        private List<string> Numbers
        {
            get => numbers;
            set => numbers = value;
        }
        private List<string> Urls
        {
            get => urls;
            set => urls = value;
        }

        public string Call()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var number in numbers)
            {
                bool result = number.Any(x => char.IsLetter(x));
                if(!result)
                {
                    sb.AppendLine($"Calling... {number}");
                }
                else
                {
                    sb.AppendLine($"Invalid number! - {number} ");
                }
            }
            return sb.ToString();
        }

        public string Browse()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var url in urls)
            {
                bool result = url.Any(x => char.IsDigit(x));
                if(!result)
                {
                    sb.AppendLine($"Browsing: {url}");
                }
                else
                {
                    sb.AppendLine($"Invalid url! - {url} ");
                }
            }
            return sb.ToString();
        }
    }
}

