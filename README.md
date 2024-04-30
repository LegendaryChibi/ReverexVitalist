# Vitalist

## Summary

This is a project containing a basic base system for a second player in an award winning game called Reverex, of which I was the **Programming Lead**. The second player is responsible for playing optional minigames as well as being foreceably prompted to play minigames.

## Basic System

This project containes a Minigame base class as well as a Minigame Manager script which allows classes that inherit from the Minigame class to be added to the manager making them selectable to the user. This script is the simplest form of this system when it was first in development. 

Additionally pop up minigames can also be added which forcibly prompt the player to play them, overriding their controls until they do so. 

If an optional minigame is currently in play and the pop up is triggered based on a set timer in the editor, the minigame will be held in a queue until the current game is complete. All minigames by default have a 5 second time limit, which will obviously be adjusted per minigame.

## Offical Trailer

[![Trailer](https://i.ytimg.com/vi/ZynOaqeCD0A/maxresdefault.jpg)](https://www.youtube.com/watch?v=ZynOaqeCD0A)


## Purpose

This system was created in such a way that allows the number of minigames and pop ups minigames to be infinitley scaled up or scaled back based on the current project scope, allowing both programmers and artists flexibility while they work towards the finished game. Reverex won ⭐**3rd Place**⭐ for *Technical Innovation* at the **Level Up Student Showcase 2024** in Toronto.
