<h1>Lab 8: Repository Pattern</h1>

 **CS246 System Design**

**Contents**

[TOC]

## Introduction

Choose any ASP.NET MVC web app that doesn't already have the repository pattern applied to it. This could be:

- Your web app for CS 295N, Web Development 1: ASP.NET
- Your instructor's example code for 2026, [Code Reviews](https://github.com/ProfBird/BrianBird_CS295N_Labs_W26)

## Repositories and Unit Tests

Add repositories and unit tests to your web site.

1. Create a repository interface for the DbSet class that is based on your "top level" model.

   (For example, if I have a User class that is part of my Review class, then, for this lab assignment, I just need to create IReviewRepository.)
   
2. Create a "real" repository based on the interface above.

3. Replace the code in each of your controller methods that uses your DB context with code that uses the repository. This will require adding dependency injection for your repository.

4. Write a fake repository. You can put this in the main project or the test project.

5. Add unit tests for at least one of your controller methods that uses a repository.

   Choose a method that do something worth testing. These would be controller methods that actually does some kind of processing like:

   - Adding information to a model property (a date, a user, etc.)
   - Searching or sorting data it gets from the database.
   - Calculating some kind of result based on user data.
   
   Remember that you are testing what the controller method does, not what the fake repository does.



## Submission to Moodle

- In the "online text" for the Moodle assignment paste a link to the branch of your GitHub repository for this lab.
- Upload two screenshots, one of unit tests passing and one of the site running on your local machine.