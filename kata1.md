# First kata session for Celtic Egyptian Ratscrew game

## Problem: write the snap validating portion of the game.
The rules in the README.md for this kata tells us that players in the game can perform a snap at any point during the game. Given this rule, we need a way to be able to comfirm whether or not it is valid to snap the current stack of cards.

## Learning objective: easily extensible code design
While writing your solution, consider the following:
* In what different ways could the snap validator be implemented?
* Without doing any coding, consider the first of the below steps - how would you implement this? If you were now asked to implement the second step what would you have to change to be able to write a solution you're happy with?
* If you consider the whole set of steps before you start coding, how would your initial design as above change? Is there some standard design practice, or a specific workflow you could apply with future problems, so that your code is as flexible as your new design, but with only the information in the first step? Does one of the [SOLID principles](http://www.codeproject.com/Articles/703634/SOLID-architecture-principles-using-simple-Csharp) help us with this?

## Tasks
Prior to starting the real tasks below, get yourself a proper environment set up. All you need to do is *fork* [this repository](https://github.com/lukedrury/celtic-egyptian-ratscrew-code-kata), and then clone that fork on your machine. In your clone you will find some code to start you off on the branch `kata1-start`.

Your goal isn't to write the whole application yet (that will come in the next few katas), but just a subsection of it. Specifically, we want to write the functionality that will analyse a stack of cards for us, and tell us whether or not it is valid to perform a snap on it.

With the above in mind, create a snap validator which is capable of detecting:

1. *standard* snaps.
2. *sandwich* snaps.
3. *dark queen* snaps.
