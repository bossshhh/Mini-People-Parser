# Mini-People-Parser
# 👤 CSV to C# Objects

This is a simple beginner-friendly C# console app that reads data from a `.csv` file and converts each row into a `Person` object — then prints a readable sentence about each one.

Think of it as a hands-on intro to file I/O, object-oriented programming, and basic data parsing in C#.

---

## 🔍 What It Does

- Loads a `.csv` file (like `values.csv`) from the project directory.
- Reads each line and splits it by commas.
- Matches headers to values (e.g., `firstname`, `lastname`, `workspace`, `age`).
- Creates a list of `Person` objects from the CSV rows.
- Prints out something like:

```text
Bashar soufan is 21 years old and works in a remote job as a SWE.
Jadd Rajab is 20 years old and works in a Office job as a physiotherapist.
Nasser AlTaweel is 28 years old and works in a Remote job as a Financer.

