# Turtle Challenge

This is a very fun game! Turtle challenge is a game like a Mined Field where you must guide a turtle until to the exit door, without touching in any mine.

All the game UI interface is a console application that will print out on the console standard output all the steps the Turtle will perfom on this game.

To allow the Turtle make some steps or decide what is the direction that it must go, you have to configure 2 configuration files: `game-settings.json` and `actions-settings.json`.

In the `game-settings.json` file, you will find the main configuration for a game, containing information such as:

- Panel Size
- Exit Door position
- Mines positions
- Turtle start position and the starting direction

In another file, `actions-settings.json`, you will find all the movements the Turtle can do for a given round game. All the allowed movements can be interpreted as: `Move` or `Rotate`. For a `Move` movement, it does mean that the Turtle can walk to Up, Down, Left or Right. On the other hand, for `Rotate` movement (or, if you prefer, an **Action**), the turtle must turn around itself, change its direction to North, South, West, East.

# Run the application
To run this game, you can follow all the steps below:

1. Clone this repository and then navigate to the project folder:
```
|> cd turtle-challenge
```