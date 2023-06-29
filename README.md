# Sokoban Game
Sokoban is a logic game that serves as a puzzle for moving objects. The objective of the game is to move all the objects to predetermined positions on the game board.

![Welcome Form](https://github.com/AliaksandraH/Sokoban-Game/blob/main/Welcome%201.png)

The player controls a character who can move in four directions (up, down, left, right) and push objects in front of them.

![Single game-Level 1](https://github.com/AliaksandraH/Sokoban-Game/blob/main/Single%20Level%201.png)

The game board consists of a grid with walls, free cells, and target positions for the objects. The player can move through free cells and push objects. They cannot pass through walls or other objects, and can only push one object at a time.
The game becomes increasingly challenging with each level, as the player must plan their moves to avoid getting stuck with objects in corners or blocking the path to target positions. Success in the game requires analysis and planning to optimally move objects and achieve the goals.
Sokoban offers a variety of levels with different difficulties, allowing players to enjoy various puzzles and challenges. It is a game that develops logical thinking, planning, and patience, and allows players to enjoy the engaging process of solving puzzles.

![Single game-Level 10](https://github.com/AliaksandraH/Sokoban-Game/blob/main/Single%20Level%2010.png)


In the game of Sokoban, the option of playing with two players has been added, both on a single keyboard and through TCP/IP using the server and client mode.
When the game is launched in two-player mode on a single keyboard, players can control their characters using different sets of keys. For example, one player may use the WASD keys for movement, while the other player uses the arrow keys. Players take turns making their moves, moving objects on the game board and striving to reach the target positions.

![Cooperative game-Level 6](https://github.com/AliaksandraH/Sokoban-Game/blob/main/Cooperative%20Level%206.png)

In the TCP/IP mode of the two-player game, one player acts as the server and the other as the client. The player who launches the server listens on a specific port and waits for the client to connect. Once the client connects to the server, both players can interact with each other over the network.

![Welcome Form for Client](https://github.com/AliaksandraH/Sokoban-Game/blob/main/Welcome%202.png)

In the TCP/IP mode, each player can control their character on their own side of the game board. Players' moves are transmitted over the network: the server receives the client's moves and applies them to its own game board, and the client receives the server's moves and applies them to its own game board. This way, players can see the changes happening on the other player's game board and interact with each other.

![Server and Client-Level 2](https://github.com/AliaksandraH/Sokoban-Game/blob/main/Server%20and%20Client%20Level%202.png)
