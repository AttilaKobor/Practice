package Study;

import java.text.DateFormat;
import java.text.SimpleDateFormat;

public class BlogPost {
    String authorName;
    String title;
    String text;
    SimpleDateFormat publicationDate = new SimpleDateFormat("yyyy-MM-dd");
    String quote;

    public BlogPost(){

    }
    public void print(){
        System.out.println(title + " titled by " + authorName + " posted at" + publicationDate);
        System.out.println();
        System.out.println(quote);
    }
}
