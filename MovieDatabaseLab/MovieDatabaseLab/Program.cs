using MovieDatabaseLab;

MovieClass movieOne = new MovieClass("Toy Story", "animated");
MovieClass movieTwo = new MovieClass("The Incredibles", "animated");
MovieClass movieTen = new MovieClass("Star Wars", "scifi");
MovieClass movieThree = new MovieClass("Monsters", "animated");
MovieClass movieFour = new MovieClass("Vertigo", "drama");
MovieClass movieFive = new MovieClass("Gladiator", "drama");
MovieClass movieSix = new MovieClass("The Social Network", "drama");
MovieClass movieSeven = new MovieClass("Trap", "horror");
MovieClass movieEight = new MovieClass("Speak No Evil", "horror");
MovieClass movieNine = new MovieClass("Never Let Go", "horror");


List<MovieClass> movieList = new List<MovieClass>()
{ movieOne,
  movieTwo,
  movieThree,
  movieFour,
  movieFive,
  movieSix,
  movieSeven,
  movieEight ,
  movieNine,
  movieTen};

string userAnswer = "y";

Console.WriteLine("Welcome to the Movie List Application!");

Console.WriteLine();

Console.WriteLine("There are ten movies in this list with the following catagories:\n" +
    "1.Animated\n" +
    "2.Drama\n" +
    "3.Horror\n" +
    "4.Scifi\n");

while (userAnswer.ToLower().Trim() == "y")
{
    Console.WriteLine("Please enter a movie catagory");
    string userCategory = Console.ReadLine();

    if (userCategory.ToLower().Trim() != "animated" && userCategory.ToLower().Trim() != "drama" && userCategory.ToLower().Trim() != "horror" && userCategory.ToLower().Trim() != "scifi")
    {
        Console.WriteLine("Catagory entered in not valid");
    }
    else
    {
        List<MovieClass> returnedList = movieList.Where(x => x.movieCategory.Trim().ToLower().Contains(userCategory.Trim().ToLower())).ToList();
        
        foreach(MovieClass movie in returnedList)
        {
            Console.WriteLine($"{movie.movieTitle}");
        }
        
        Console.WriteLine();

        Console.WriteLine($"");

        Random randomObject = new Random();
        MovieClass returnedObject = returnedList.ElementAt(randomObject.Next(0, returnedList.Count));
        Console.WriteLine($"A random movie in the category {userCategory.Trim().ToLower()}: {returnedObject.movieTitle}.");
    }

    Console.WriteLine();

    Console.WriteLine("Woule you like to continue? (y/n)");
    userAnswer = Console.ReadLine();

    if (userAnswer.ToLower().Trim() == "y")
    {
        continue;
    }
    else if (userAnswer.ToLower().Trim() == "n")
    {
        Console.WriteLine("Goodbye!");
        break;
    }
}



