# snack-game
 a simple snack game that can be played on terminal 

# How to run this project
### Step 1: Install Required Software  
-Download Visual Studio Code (https://code.visualstudio.com/)  
-Download .NET SDK (https://dotnet.microsoft.com/en-us/download/dotnet) (Required to run C# programs)  
--Check Installation:  
--Open Command Prompt (Win + R → type cmd → press Enter).  
--Type:
```ruby
dotnet --version
```
--If you see a version number, .NET SDK is installed correctly.  

### Step 2: Open VS Code & Install C# Extension  
-Open VS Code.  
-Go to Extensions (Ctrl + Shift + X).  
-Search for C# and install the extension by Microsoft.  

### Step 3: Create a New C# Project  
-Open VS Code and create a new folder (e.g., SnackGame).  
-Open the folder in VS Code (File → Open Folder → Select SnackGame).  
-Open the terminal in VS Code (Ctrl + ~).  
-Run this command to create a new C# console project:  
```ruby
dotnet new console -n SnackGame
```
-Navigate into the new project folder:  
```ruby
cd SnackGame
```

### Step 4: Replace or Delete the Code Program.cs that was created on Step 3.  

### Step 5: Run the Game
-Open the terminal (Ctrl + ~).
-Run the following command:  
```ruby
dotnet run
```
-Your Snack Game should now start in the terminal!  

### Step 6: Play the Game  
-Use the arrow keys to move @.  
-Eat * to increase the score.  
-Press Q to quit the game.  

### Step 7: (Optional) Build an Executable
-If you want to create an executable (.exe), run:
```ruby
dotnet build
```
--------This will create a file inside bin/Debug/net8.0/ (or your installed version).------
