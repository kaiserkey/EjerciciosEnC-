## Definición del Problema

Diseña un programa en C# que determine si dos palabras son anagramas.

### ¿Qué es un anagrama?

Dos palabras son **anagramas** si contienen exactamente las mismas letras con la misma frecuencia, aunque el orden sea diferente. Por ejemplo:

- **Silent** → **Listen**
- **Post** → **Opts**

---

## Ejemplos

| **Entrada**                | **Salida**                                             |
|----------------------------|--------------------------------------------------------|
| "Listen", "Silent"         | Yes! Words "Listen" and "Silent" are Anagrams          |
| "Hello", "World"           | No! Words "Hello" and "World" are not Anagrams         |
| "Astronomer", "Moonstarer" | Yes! Words "Astronomer" and "Moonstarer" are Anagrams  |
| "Apple", "Papel"           | Yes! Words "Apple" and "Papel" are Anagrams            |

---

## Explicación del Problema

El objetivo del programa es verificar si dos palabras son anagramas. Esto implica comprobar que ambas contienen las mismas letras y la misma cantidad de cada letra, independientemente del orden.

### Reglas importantes:
- Las comparaciones no deben ser sensibles a mayúsculas o minúsculas.
- Se asume que las palabras no contienen espacios, números ni caracteres especiales. (Puedes validar esto si lo consideras necesario).

---

## Desglose de la Solución

### Entrada:
Dos palabras proporcionadas por el usuario.

### Salida:
Un mensaje que indica si las palabras son anagramas o no.

### Estrategia:
1. Convertir ambas palabras a minúsculas para evitar diferencias de mayúsculas y minúsculas.
2. Transformar las palabras en arreglos de caracteres.
3. Ordenar los arreglos de caracteres.
4. Convertir los arreglos ordenados de nuevo en cadenas.
5. Comparar las cadenas resultantes:
   - Si son iguales, las palabras son anagramas.
   - Si no son iguales, no lo son.

---

### Reglas adicionales:
- Validar que ambas palabras no estén vacías.
- **Opcional:** Validar que solo contengan letras del alfabeto.

---

## Pseudocódigo

```plaintext
Recibir las dos palabras del usuario.
Convertir ambas palabras a minúsculas.
Transformar las palabras en arreglos de caracteres.
Ordenar los arreglos de caracteres.
Convertir los arreglos ordenados en cadenas.
Si ambas cadenas son iguales:
    Las palabras son anagramas.
Si no:
    Las palabras no son anagramas.
```
    

### Preguntas de Práctica
¿Qué sucede si una de las palabras está vacía?

¿Qué pasaría si las palabras contienen números o caracteres especiales?

¿Cómo podrías optimizar el código si sabes que las palabras son extremadamente largas?

### Ejercicios Adicionales
Modifica el programa para que ignore espacios en las palabras (por ejemplo, "Astronomer" y "Moon starer" deben ser anagramas).

Implementa una versión que permita verificar si dos frases completas son anagramas.

Escribe una variante que cuente cuántas letras faltan para que dos palabras sean anagramas.