package main.java;

import opennlp.tools.sentdetect.SentenceDetectorME;
import opennlp.tools.sentdetect.SentenceModel;

import java.io.File;
import java.io.FileInputStream;

public class SentencePosDetection {

    public static void main(String[] args) throws Exception {

        var paragraph = "Hi. How are you? Welcome to this example. "
                + "This is a sentence! My name is Panagiotis btw";

        var basePath = new File("").getAbsolutePath();

        // Loading sentence detector model
        var inputStream = new FileInputStream(basePath + "/OpenNLP/en-sent.bin");
        var model = new SentenceModel(inputStream);

        // Instantiating the SentenceDetectorME class
        var detector = new SentenceDetectorME(model);

        // Detecting the sentences
        var sentences = detector.sentDetect(paragraph);

        // Printing the sentences
        for (String sent : sentences)
            System.out.println(sent);
    }
}
