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
This project is using .NET 6, it's recommended that you already have .NET 6 installed on your machine.

To run this game project, you  can follow all the steps below:

1. Clone this repository and then navigate to the project folder:
```
|> cd turtle-challenge\src
```
2. Build the solution
```
|> dotnet build .\TurtleChallenge.sln
```
After that, it will create a `bin` folder in `TurtleChallenge`

To run the this game for the first time, it already has configured settings files. It is just run the app providing a couple of file settings. You also can configure those settings files as your own, but take into consideration, when configuring the `Panel Size` and the other positions.

3. Running this game app
```
|> .\TurtleChallenge.Console\bin\Debug\net6.0\TurtleChallenge.Console.exe .\TurtleChallenge.Console\GameSettings\game-settings.json .\TurtleChallenge.Console\GameSettings\actions-settings.json
```

After running the app, you should have this output:

![](https://github.com/jr-araujo/turtle-challenge/blob/main/images/output-after-running.png)

Congrats! Your app now is running.