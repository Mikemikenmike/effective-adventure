# effective-adventure
*Big goals, small production ability, mediocre talent -- welcome home boys.*

### Today's hot new news.
Our voxel game's humble journey begins here. 

Maxx, if you get around to the summary of what we were discussing, you can throw an abstract of that under the idea chapter. This cloning instructions are for you as well.


### Table of Contents
1. The idea
2. Assumptions and Scope
2. Sort of what Git and Github are and how to get this repository

## The Idea
* Focus on simple block primitives. For example, instead of railroad tracks being a block, they are simply made by laying parallel rows of generic blocks.
* Focus on making the world come alive through utilization/development of land by NPCs that emulate and mutate the player's designs.

## Assumptions and Scope

##### Environment
Building for Windows on Windows (Definitely need to discuss this more).  
Unity 2018.1 [Download](https://store.unity.com/) [Blog](https://blogs.unity3d.com/2018/05/02/2018-1-is-now-available/)  
Rider IDE [Download]([Now download Rider](https://www.jetbrains.com/rider/))

##### Game
Survival game.  
World will be an infinitely and procedurally generated voxel plane with harvest-able resources.  
Multiplayer first architecture (whatever this means).  



## Sort of what Git and Github are and how to get this repository

Welcome to github. This will be a brief explanation of what this website and git itself is for as I understand it. Smarter people might have better explanations.

__github__ stores our project code online.

__git__ is a version control program. There's a lot to it, but you'll want to know the following actions to get started:

1. clone: Copy a repository from one place to another. Use clone to copy this repo from github to your computer. You now have a local copy.
2. commit: Adds a change you've made to version control. ALWAYS include a comment with a brief description of your change.
   * Commits are reversion points and can serve as a log for progress. 
3. push: Sends your commits to github. Until this is done, all of your commits are local (read: vulnerable to hard drive failure and inaccessible to everyone else.)
4. pull: Gets commits from github to update your local copy. Pull often. 
5. merge: Used to combine one set of commits with another. Normally invisible unless there is a conflict. e.g:
   * Jake edits line 104 of this readme and pushes to server.
   * Mike doesn't pull, then edits line 104 of this readme and attempts to push to server.
   * Because Mike edited an older version of the code, the server doesn't know which change we desire.
   * Mike now has to pull, merge, and resolve this conflict somehow (like throw out Jake's change).
   * Mike can now commit again and push to server.
   * **Avoid conflicts by:** Pulling often, like when you sit down to start working, and assigning tasks so different people aren't working on the same file.
   
   
### [Download git here](https://git-scm.com/downloads)

Open the command prompt and navigate to the directory you want this repo to be stored in.
   * e.g. Say you create a folder called repos on you D: drive. Get there in the command prompt with these commands:
```
d:
cd repos
```

Now you'll want to clone this repository. The following command will make a folder called 'effective-adventure' within 'd:\repos\' that contains our whole project. **YOU MAY RUN INTO AUTH ISSUES** so try to follow the bouncing ball there... I don't set up git often enough to know the process but if you can't figure it out I'll help.

```
git clone https://github.com/Mikemikenmike/effective-adventure.git
```

This folder is a git initialized folder, meaning that the commands listed above will work. If you change something, like this document, you will be able to commit and push it to github. You can commit new files and commit deleted files. You git the point. 

### [Now download Rider](https://www.jetbrains.com/rider/)

This IDE is designed for C# and has native Unity support. Visual Studio would be its competitor I guess. 

During setup, choose the IDEA Default Keymap if you want Jake or I to be able to help with that. Feel free to choose your aesthetic. Just use the default modules or whatever when they ask.

I'm not including the rider section to tell you about the benefits of the IDE, but to let you know that it has amazing Git integration. With Rider, you won't have to use the command line to commit, push, pull, merge, add, delete, revert, branch, checkout, fork, rebase, rebuild, commute, eat, sleep, socialize, or love. The IDE does it all with _buttons_ and shows you _pictures._ Highly recommend. 

So, after you clone the repo, open Rider, file>open>d:/repos/effective-adventure or wherever you put it. 