//Si vuole progettare un sistema per la gestione di una biblioteca. Gli utenti si possono registrare al sistema, fornendo:
//cognome,
//nome,
//email,
//password,
//recapito telefonico,
//Gli utenti registrati possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD). I documenti sono caratterizzati da:
//un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
//titolo,
//anno,
//settore(storia, matematica, economia, …),
//stato(In Prestito, Disponibile),
//uno scaffale in cui è posizionato,
//un autore (Nome, Cognome).
//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.
//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.

//---------------

//Analizziamo il codice e cerchiamo di ricostruire la situazione, magari generando uno schema E/R per capire quali tabelle e quali relazioni creare
//Ricordatevi di creare una nuova connessione e un nuovo db per il progetto, non vi servirà caricarlo online, vi basta che esista sulla vostra macchina locale.
//Con lo schema E/R precedente e osservando il codice che abbiamo scritto nel precedente progetto, scriviamo le query per creare le tabelle (potete anche usare l’editor di visual studio)
//Una volta prodotto il DB modifichiamo il codice del vecchio programma in modo che possa leggere e scrivere dal database invece che dalle istanze di oggetti creati a runtime

using System.ComponentModel;
using System.Data.SqlClient;

string dbStringLink = "Data Source=localhost;Initial Catalog=db-library;Integrated Security=True";

//Library library = new Library();

//User user = new User("Francesco", "Ricchiuti", "francesco@email.com", "12345678", "3450000000");
//Console.WriteLine($"{user.Name} {user.Surname}, {user.Email}, {user.Password}, {user.MobileNumber}");

//library.AddUser(user);


SqlConnection SqlConnection = new SqlConnection(dbStringLink);

try
{
    SqlConnection.Open();

    string queryBook = "INSERT INTO Book (Title, Author, Isbn, PageNumber) VALUES (@title, @author, @isbn, @pageNumber)";

    SqlCommand cmd = new SqlCommand(queryBook, SqlConnection);
    cmd.Parameters.Add(new SqlParameter("@title", "Harry Potter e la pietra filosofale"));
    cmd.Parameters.Add(new SqlParameter("@author", "Cristiano Malgioglio"));
    cmd.Parameters.Add(new SqlParameter("@isbn", "6273827364924"));
    cmd.Parameters.Add(new SqlParameter("@pageNumber", 400));

    int affectedRows = cmd.ExecuteNonQuery();
}
catch (Exception e)
{
    Console.WriteLine($"ERROR {e}");
}
finally
{
    SqlConnection.Close();
}