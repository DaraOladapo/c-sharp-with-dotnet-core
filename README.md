# Getting started with C# and .NET Core

This is a beginner code sample for learning C# and .NET Core.

## Requirements

- .NET Core Core SDK
- Visual Studio Code or Visual Studio (for the first part, we will be using VS Code)

To get the .NET SDK, visit dot.net and get the latest version. After installation, verify you installation by running

    dotnet --version

On my Mac, I have .NET Core 3 SDK Installed as of when writing this. so I get.

    GWL-Mac:c-sharp-with-dotnet-core daraoladapo$ dotnet --version
    3.0.100-preview6-012264

The version number displayed may be different from what you have on your computer which is totally fine.

Run `dotnet new` and it will show you a list of available app options to build with your installed version of .NET Core

## Structure

The lesson files are broken down into basic chunks to grasp and progress from simple to a 'lil bit more complex lessons.

### Starting with Console

This will be the first part of this series.

#### Lesson 1

-------------

Most developers started writing thier coding career with a `Hello World`.

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

#### Lesson 2

-------------

In Lesson 2, we will be talking about basic C# data types.
This does not cover all but the most data types you'll be using in the course of this lesson will be covered. Here they are.

Data Type | Description and Usage
----------|----------------------
string | representing alphanumeric characters
int | representing whole numbers
double | representing decimal numbers
float | reperesenting floating point numbers

#### Lesson 3

Q: How do we then use data types?

A: We declare them as variables.

A variable is a name given to a storage area that is used to store values of various data types. (Ref: <https://www.guru99.com/c-sharp-variables-operator.html)>

A variable needs to represent a data type -simple or custom-defined.

In this lessson, we use the basic data types and do some operations on them.

We also introduce the concept of statements, operators and comments.

#### Lesson 4

In the last lesson, one of the statements was returning a value that was normally not expected an ideal

#### Lesson 5

Let's play with some strings in this lesson -  concatenations and escape sequences.

#### Lesson 6

One important part of amy app/program is the use of dates and times. In this lesson, we walk through the usage of the `DateTime` data type.

#### Lesson 7

#### Lesson 8

#### Lesson 9

#### Lesson 10

#### Lesson 11

#### Lesson 12

#### Lesson 13

#### Lesson 14

#### Lesson 15

#### Lesson 16

#### Lesson 17

#### Lesson 18

#### Lesson 19

#### Lesson 20
