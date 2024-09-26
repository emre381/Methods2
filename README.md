
---

# Methods Demonstration Program

## Description

This C# console application demonstrates the use of various methods to perform calculations, manipulate strings, and check conditions. The program includes examples of arithmetic operations, finding the larger number, squaring a number, and verifying a user input condition.

## Features

- Adds two numbers and returns the result.
- Concatenates first and last names into a full name.
- Squares a given number.
- Compares two numbers and returns the larger one.
- Verifies whether the user has the required "key" by checking their input.

## Requirements

- .NET SDK (Core or Framework) installed on your machine.

## Usage

1. Clone or download this repository to your local machine.
2. Open the project in your preferred C# IDE (like Visual Studio or Visual Studio Code).
3. Build the project.
4. Run the application.
5. Follow the prompts and observe the results.

## Example

Here is an example of the program in action:

```
26
Emre Çınar
12.5 sayısının karesi : 156.25
34
Sizde anahtar var mı ? varsa Var yazın :
Var
İçeri girebilrisiniz
```

## Code Explanation

- **Main Method**: 
  - Demonstrates the functionality of different methods.
  - Calls `hesapla`, `bilgileriHesapla`, `kareAl`, `buyukSayiBul`, and `anahtarVarMi` methods and prints their results.

- **Methods**:
  - `hesapla`: Adds two integers and returns the sum.
  - `bilgileriHesapla`: Concatenates and returns the full name from given first and last names.
  - `kareAl`: Calculates and returns the square of a given double value.
  - `buyukSayiBul`: Compares two numbers and returns the larger one.
  - `anahtarVarMi`: Checks whether the input string matches the word "Var", indicating the user has a key, and returns a boolean.

## Detailed Functionality

1. **`hesapla(int x, int y)`**: Adds two integers `x` and `y` and returns their sum.
   - Example: `hesapla(5, 6)` returns `11`.

2. **`bilgileriHesapla(string isim, string soyisim)`**: Concatenates the `isim` (first name) and `soyisim` (last name) and returns the full name.
   - Example: `bilgileriHesapla("Emre", "Çınar")` returns `"Emre Çınar"`.

3. **`kareAl(double x)`**: Returns the square of the number `x`.
   - Example: `kareAl(12.5)` returns `156.25`.

4. **`buyukSayiBul(double sayi1, double sayi2)`**: Compares two numbers and returns the larger one.
   - Example: `buyukSayiBul(28, 34)` returns `34`.

5. **`anahtarVarMi(string ifade)`**: Checks if the user input is `"Var"` and returns `true` or `false` based on the input.
   - Example: If the user inputs `"Var"`, the method returns `true` and allows access.

## License

This project is open-source and available under the MIT License.

---

