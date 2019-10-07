using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_LibraryIterator {
    class Library : IEnumerable<Book> {
        private readonly List<Book> books;

        public Library(params Book[] books) {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator() {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private class LibraryIterator : IEnumerator<Book> {
            private readonly List<Book> books;
            private int currIndex;

            public LibraryIterator(List<Book> books) {
                this.Reset();
                this.books = books;
            }

            public Book Current => books[currIndex];
            object IEnumerator.Current => this.Current;

            public void Dispose() { }
            public bool MoveNext() => ++currIndex < books.Count;
            public void Reset() => this.currIndex = -1;
        }
    }
}
