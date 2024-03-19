package com.heterograma.isograma.pangrama;

import java.util.ArrayList;
import java.util.HashMap;

public class Main {
    public static void main(String[] args) {
        var isHeterograma = isHeterograma("qwertyuiopñlkjhgfdsazxcvbnm");
        System.out.println("Es Heterograma? " + isHeterograma + "");

        var isIsograma = isIsograma("aabbccnnjjmñmñ");
        System.out.println("Es Isograma? " + isIsograma + "");

        var isPangrama = isPangrama("El veloz murciélago hindú comía feliz cardillo y kiwi.\r\n" +
                "\r\n" +
                "La cigüeña tocaba el saxofón detrás del palenque de paja.\r\n" +
                "\r\n" +
                "Fabio me exige, sin tapujos, que añada cerveza al whisky.");
        System.out.println("Es Pangrama? " + isPangrama + "");
    }

    /**
     * Heterograma es, un texto que no contiene ninguna letra repetida
     * 
     * @param text
     * @return
     */
    private static boolean isHeterograma(String text) {
        var characters = countCharacters(text);
        for (var count : characters.values()) {
            if (count > 1) {
                return false;
            }
        }
        return true;
    }

    /**
     * Todas las letras se repiten el mismo numero de veces
     * @param text
     * @return
     */
    private static boolean isIsograma(String text) {
        var count = countCharacters(text).values().toArray();

        for (int i = 0; i < count.length; i++) {
            // Si el valor actual es diferente del anterior, es falso
            if (count[i] != count[(i == 0 ? 1 : i) -1]) {
                return false;
            }
        }
        return true;
    }

    /**
     * Pangrama, es que una frase contenga todas las letras posibles del abecedario
     * 
     * @param text
     * @return
     */
    private static boolean isPangrama(String text) {
        var abcedario = "qwertyuiopñlkjhgfdsazxcvbnm".toCharArray();
        var check = new ArrayList<Boolean>(abcedario.length);
        var counter = countCharacters(text);

        for (var abc : abcedario) {
            if (counter.containsKey(abc)) {
                check.add(true);  
            }
        }

        return check.size() == abcedario.length;
    }

    
    private static HashMap<Character, Integer> countCharacters(String text) {
        var letterCounter = new HashMap<Character, Integer>();
        var characters = text.toCharArray();

        for (var character : characters) {
            var counter = letterCounter.getOrDefault(character, 0);
            letterCounter.put(character, ++counter);
        }

        return letterCounter;
    }
}
