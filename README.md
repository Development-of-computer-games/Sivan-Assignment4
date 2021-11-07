# Sivan-Assignment4

### I chose to execute number 6 : creating the world to be "round" , if a player moves to the edge of the map, for example the right side, the player will appear in the left side accordingly, if the player moves to the upper boundry (the ceilling) , they will appear in the opposite side - the floor, with the exact same coordinate.
### The changes that i've made - I created 4 "box collider 2D", for each of them i gave the right coordinate to appear on the screen, Top wall, Down wall, Left wall and right wall.
![Screenshot 2021-11-07 133350](https://user-images.githubusercontent.com/57447482/140643193-a2c213a0-5b6d-4b48-b753-be3022957cb3.png)
### In order to catch the collision, I wrote in the player script under the "OnTriggerEnter2D" what to do when each of the collision is made.
![entercoliision](https://user-images.githubusercontent.com/57447482/140643328-6caee703-1acf-44a9-8401-0ff250d5c401.png)
<br>
### You can see more in the script, the initialization of the objects, and the rest of the additions.
[Link to the script]()

<br>
### The second thing i choose to execute was : Bombs falling from the sky, when the player collide with the bombs, all the enemies that are on the screen are exploding. For example, here we can see the enemies, our ship, and the bomb falling. When the ship is colliding with the bomb, everything exsept the ship is being destroyed.
<br>
![timebomber](https://user-images.githubusercontent.com/57447482/140648897-9d1e782c-63dc-449e-9867-adfdc38f582c.png)

<br>
### I implemented it by creating prefab "TimeBomber", then i added all the relevent categories to it : 
<br>
![bombs falling](https://user-images.githubusercontent.com/57447482/140648905-deb8c412-2b3d-4e41-8e94-ea095b1e6363.png)
<br>
### I created a script for the spawning of the bomb, and a script for the collision with the player. Once the bomb is colliding with the player, we search for all the enemy gameObject and destrying them.
[Link to the collision of the bomb]() 
<br>
[Link to the bomb spawner]()

