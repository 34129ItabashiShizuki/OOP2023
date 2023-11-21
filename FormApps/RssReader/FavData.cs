using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader {
    class FavData {
        public string Title { get; set; }
        public string Link { get; set; }

        public FavData(string Link, string Title) {
            this.Title = Title;
            this.Link = Link;
        }

        public override string ToString() {
            return Title;
        }
    }
}
