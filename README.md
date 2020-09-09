# Agile Team #2
* Joshua Kunz
* Alexander Dragseth
* Colton B Johnson
* Steven Walley
* Skyler W Whitney

#### 8/27/2020

# Budget and Financial Management Application
### Feel free to add to this document

## Helpful Articles:
* [Android MVVM Design Pattern](https://www.journaldev.com/20292/android-mvvm-design-pattern)

### Requirements:
1. Users must have a secure login
2. Users should be able to keep track of deposits(income)
3. Users should be able to create budget categories and assign money to the category
4. Users should be able to create and track expenditures against a given category
5. Users should be able to see how much money remains in a category
6. The user interface should be clean and intuitive

### Technology:
1. Language: Java
2. IDE: Android Studio
3. Version Control: GIT, or any other version control app that works with GIT.

### Design Patterns:
1. Model View ViewModel (MVVM)
2. Factory

### Roles: 
TODO: Create roles.
Just to throw out some ideas
1. Front end
2. Back end
3. Database
4. Unit tests


## Things to download:
1. [GIT](https://git-scm.com/downloads)
2. [Source Tree](https://www.sourcetreeapp.com/) if you don’t plan on using the command line
3. [Android Studio](https://developer.android.com/studio)

## Cloning The Repository To Your Local Machine
* Find the green button that says 'Code' and click on that. It will let you copy the URL to the repository.
* Create a folder and name it something like Repos
* Open a Command prompt, GIT Bash, or Terminal which ever you prefer to use (if your using the command line)
* cd into your new Repos folder
* run the following command: 
```
//Shift Insert to paste in copied text if your using git bash
git clone Url.That.You.Copied
cd AgileFinancialApp
git checkout develop
```

And if you are already ready to create your branch then run:
```
git checkout -b yourName/branchName
```

### Make sure you are not making any changes directly to the master branch OR the develop branch. All of your changes should take place on your own branch.
Make sure you checkout develop and create your branch from develop because master is for our final project updates. Before you start making changes, be sure to create a new branch with the naming convention <yourName/nameOfBranch> to keep organized. For example I would do something like:

```
git checkout develop
git checkout -b JoshKunz/CreatingModels
```

To save your changes with a commit, simply use the command:

```
git commit -am “I created some new models”
```

And to push your changes to the GitHub repository you can use the commands:

```
git push
```

Note: if it’s your first time pushing to the new branch it will show a set-upstream command to use to create the upstream.
Later on when you are finished with your branch you can set up a pull request, where everyone can look at the code and review it. Once everyone gives the thumbs up I will merge it into develop, and everyone can pull your code into their local repository.

```
git checkout develop
git pull
```
You may need to stash your changes first before you can, you may need to commit your changes before merging as well.

Once you have pulled in the new changes from develop, you will want to merge develop into YOUR branch:
```
git checkout myBranch
git merge develop
```

To avoid conflicts I would suggest that everyone works on different documents/classes.
If we change the same line of code for instance, it will trigger a conflict and you will need to decide which changes to keep.

### Useful Git commands:
If you are not using the command line, you can skip this.
You can do a simple google search on these commands to get an idea of what they do. 
* git clone
* git checkout -b branchName 
NOTE: Using -b will create a new branch based off of the branch you're currently checked out, and checks you into the newly created branch.
* git pull
* git status
* git commit -am “your commit text here” ONLY commit to your own branches
* git push ONLY push commits to your own branches
* git merge ONLY merge into your own branches
As far as merging into develop or master, you will have to set up a pull request first.

### Android Studio Setup Guide:
Follow along the chat messages in Discord.


### Design Concepts(UI):
 



### Naming Conventions:
 



### Models:
* UserModel
* DepositModel
* CategoryModel

### ViewModels:
* OverviewViewModel

### Views:
* OverviewView

### Other Meaningful Classes:
* AppService
* AppFactory


### Database Schema:
TODO:Design the database relational model for this app.

### Testing Strategies:
* Create multiple environments and use dependency injection to set which environment to use throughout the application.
* Unit tests
