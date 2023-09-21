# Code Convention Guidelines

These code convention guidelines are intended to ensure consistency and readability in your C# code. They are based on the code you provided.

## Table of Contents
1. [Naming Conventions](#naming-conventions)
2. [Code Formatting](#code-formatting)
3. [Comments](#comments)

---

## Naming Conventions <a name="naming-conventions"></a>

- Use **PascalCase** for class and method names: `class Program`, `static void Main(string[] args)`
- Use **camelCase** for variable names: `string logo`
- Use **PascalCase** for constant values: `const int LogoPadding = 5`
- Use descriptive and meaningful names: `screenWidth`, `continueGame`, `choice`, etc.
- Avoid single-letter variable names, except for simple loop counters (`i`, `j`, `k`, etc.).

---

## Code Formatting <a name="code-formatting"></a>

- Use consistent indentation with **4 spaces** for each level of nesting.
- Use meaningful whitespace to enhance readability.
- Use meaningful vertical spacing between code blocks and logical sections.

### Example:

```csharp
class Program
{
    static void Main(string[] args)
    {
        // Code goes here
    }

    static void SomeMethod()
    {
        // Code goes here
    }
}