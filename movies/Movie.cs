public class Movie {
    private string name;
    private string category;

    public Movie (){}

    public Movie (string name, string category){
        this.name = name;
        this.category = category;
    }

    public void setName(string name){
        this. name = name;
    }

    public void setCategory(string category){
        this.category = category;
    }

    public string getName (){
        return name;
    }

    public string getCategory(){
        return category;
    }

}