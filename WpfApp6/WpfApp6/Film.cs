using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class Film : INotifyPropertyChanged
    {
        private string
            title,
            director,
            publisher;
        private DateTime?
            publishDate = null;
        public enum MediaType
        {
            VHS,
            DVD,
            BlueRay
        }
        private MediaType mediaType;

        public event PropertyChangedEventHandler? PropertyChanged;
        private static Dictionary<string, ICollection<string>> powiązaneWłaściwości
        = new Dictionary<string, ICollection<string>>()
        {
            ["Title"] = new string[] { "title" },
            ["Director"] = new string[] { "Director" },
            ["Publisher"] = new string[] { "Publisher" },
            ["MediaType"] = new string[] { "MediaType" },
            ["PublishDate"] = new string[] { "Wiek" },
            ["Wiek"] = new string[] { "SkrótSzczegółów" }
        };

        void NotyfikujZmianę(
        [CallerMemberName] string? nazwaWłaściwości = null,
        HashSet<string> jużZrobione = null
        )
        {
            if (jużZrobione == null)
                jużZrobione = new();
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(nazwaWłaściwości)
                );
            jużZrobione.Add(nazwaWłaściwości);
            if (powiązaneWłaściwości.ContainsKey(nazwaWłaściwości))
                foreach (string powiązanaWłaściwość in powiązaneWłaściwości[nazwaWłaściwości])
                    if (jużZrobione.Contains(powiązanaWłaściwość) == false)
                        NotyfikujZmianę(powiązanaWłaściwość, jużZrobione);
        }

        public string Title
        {
            get => title;
            set
            {
                title = value;
                NotyfikujZmianę();
            }
        }
        public string Director
        {
            get => director;
            set
            {
                director = value;
                NotyfikujZmianę();
            }
        }
        public string Publisher
        {
            get => publisher;
            set
            {
                publisher = value;
                NotyfikujZmianę();
            }
        }
        public DateTime? PublishDate
        {
            get => publishDate;
            set
            {
                publishDate = value;
                NotyfikujZmianę();
            }
        }
        public ushort? Wiek
        {
            get
            {
                if (publishDate == null)
                    return null;
                DateTime? koniec = DateTime.Now;
                TimeSpan różnica = (TimeSpan)(koniec - publishDate);
                return (ushort)Math.Floor(różnica.Days / 365.25);
            }
        }
        public string SkrótSzczegółów
        {
            get
            {
                if (publishDate == null)
                    return title;
                else
                    return $"{title}, opublikowany {Wiek} lat temu";
            }
        }
    }
}
