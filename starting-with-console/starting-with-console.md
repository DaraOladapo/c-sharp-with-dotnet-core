# Starting with the Console

This will be the first part of this series.

## Lesson 1

-------------

Most developers started writing their coding career with a `Hello World`.

Lesson 1 get us started with a Console App displaying Hello World.

Go to your favorite folder where you want your code files saved and open in Terminal (Mac), PowerShell or Command Prompt (Windows), Bash (Linux)

Type `dotnet new console -o lesson-01-hello-world` and hit 'Enter' on your keyboard.

This command creates a .NET Core Console application in a new folder called lesson-01-hello-world

Next step, type `cd lesson-01-hello-world` in your commandline/terminal, hit enter then next type `dotnet run` and hit 'Enter' again.

You should get this shown to you.

        Hello World!

You may ask, I didn't write any code. Yes, that is true. What happened behind the scenes was that the `dotnet new console` command created a template program file you that looks like this.

        using System;

        namespace lesson_01_hello_world
        {
            class Program
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Hello World!");
                }
            }
        }

So, the dotnet run command simply executed the `Console.WriteLine("Hello World!");` statement and displayed `Hello World!` to us.

More details [here](lesson-01-hello-world/hello-world.md).

## Lesson 2

-------------

In Lesson 2, we will be talking about basic C# data types.
This does not cover all but the most data types you'll be using in the course of this lesson will be covered. Here they are.

Data Type | Description and Usage
----------|----------------------
string | representing alphanumeric characters
int | representing whole numbers
double | representing decimal numbers
float | reperesenting floating point numbers
bool | used to determine the truth value of an assignment

More details [here]().

## Lesson 3

Q: How do we then use data types?

A: We declare them as variables.

A variable is a name given to a storage area that is used to store values of various data types. (Ref: <https://www.guru99.com/c-sharp-variables-operator.html)>

A variable needs to represent a data type -simple or custom-defined.

In this lessson, we use the basic data types and do some operations on them.

We also introduce the concept of statements, operators and comments.

More details [here]().

## Lesson 4

In the last lesson, one of the statements was returning a value that was normally not expected an ideal.

More details [here]().

## Lesson 5

Let's play with some strings in this lesson -  concatenations and escape sequences.

More details [here]().

## Lesson 6

One important part of amy app/program is the use of dates and times. In this lesson, we walk through the usage of the `DateTime` data type.

More details [here]().

## Lesson 7

More details [here]().

## Lesson 8

More details [here]().

## Lesson 9

More details [here]().

## Lesson 10

More details [here]().

## Lesson 11

More details [here]().

## Lesson 12

More details [here]().

## Lesson 13

More details [here]().

## Lesson 14

More details [here]().

## Lesson 15

More details [here]().

## Lesson 16

More details [here]().

## Lesson 17

More details [here]().

## Lesson 18

More details [here]().

## Lesson 19

More details [here]().

## Lesson 20

More details [here]().
