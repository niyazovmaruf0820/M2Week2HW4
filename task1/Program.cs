using task1;

Book book = new Book("Harry Potter", "Pushkin", 2015);

book.GetInfo();
System.Console.WriteLine("Is Published : " + book.IsPublishedRecently());