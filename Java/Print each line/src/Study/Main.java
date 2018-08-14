package Study;

import javax.sound.sampled.Line;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.NoSuchFileException;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.List;

public class Main {

    public static void main(String[] args) throws IOException {
        try {
            for (String line : Files.readAllLines(Paths.get("my-file.txt")))
            {
                System.out.println(line);
            }

        } catch (NoSuchFileException e)
        {
            System.out.println("There is no such file!");
        }


    }
}
