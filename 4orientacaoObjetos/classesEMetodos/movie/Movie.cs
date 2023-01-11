class Movie {
    string _category;
    public string Title { get; set; }
    public string Category
    {
        get {return _category;}
        set {
                if (value != "Fantasia" && value != "Ficcao Cientifica")
                    throw new Exception("Category not allowed");
                _category = value;
            } 
    }

    public Movie(string title, string category)
    {
        Title = title;
        Category = category;
    }
}