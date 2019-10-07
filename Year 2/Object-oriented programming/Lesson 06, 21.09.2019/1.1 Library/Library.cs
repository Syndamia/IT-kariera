using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_Library {
    class Library : IEnumerable<Book> {
        private readonly List<Book> books;

        public Library(params Book[] books) {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator() {
            for(int i = 0; i < books.Count; i++) {
                yield return books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
