# Bounce-A-Ball Project in the Unity World 

This is Yunzi Wang's individual exercise project for game design and programming.

## Project Overview
This is a simple roll-a-ball project built in the Unity environment. 
It was first designed to reproduce the [Ballance](https://en.wikipedia.org/wiki/Ballance) game, to explore the 3D puzzle video game world and to teach myself basics of [Unity](https://unity.com) and [C#](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/).

When setting up the level environment, I became intrigued to create a girlish and fantasy-like atmosphere with creamy color schemes. And I also had a good grasp of concepts like [physical material](https://docs.unity3d.com/Manual/class-PhysicMaterial.html), [prefab](https://docs.unity3d.com/Manual/Prefabs.html), [instantiate](https://docs.unity3d.com/ScriptReference/Object.Instantiate.html), [rigid body](https://docs.unity3d.com/ScriptReference/Rigidbody.html), etc. Therefore, I added many classic elements of roll-a-ball games, such as coin eating, snake zigzagging, and material changing.

## Game Snapshots


👉🏼The overall game view:
<pre>
<p align="center">
  <img src="https://github.com/ValerieWang628/balance-ball/blob/master/snap/snap3.png" width="600" height="375">
</p>

In this game, the player will have a third-person perspective.
They also need to control the rolling ball with WASD commands. 
At the same time, players hit the whitespace to make the ball jump. 
There are also constantly rotating coins floating on the blocks. 
Instead of collison bodies, they work as triggers. 
If touched by the player, they disappear. 
Currently, it lacks an UI letting user know the score and prompt. 
Later, the UI layer will be added.
</pre>

👉🏼The overall scene view:
<pre>
<p align="center">
  <img src="https://github.com/ValerieWang628/balance-ball/blob/master/snap/snap5.png" width="600" height="375">
</p>
</pre>


👉🏼Close-up snapshots:
<pre>
<p align="center">
  <img src="https://github.com/ValerieWang628/balance-ball/blob/master/snap/snap7.png" width="600" height="375">
</p>

Notice that there is a square mat with a lighter gray than the start mat. 
It is placed in the center of the snake puzzle. 
This light gray mat is a collision body. 
Once the ball hits the mat, the material and mass of the ball change.
This is a test for both the collision detection mechanism and physical material change mechanism.
</pre>

<pre>
<p align="center">
  <img src="https://github.com/ValerieWang628/balance-ball/blob/master/snap/snap2.png" width="600" height="375">
</p>

The player will have to be comfortable with the jump movement to make the ball climb stairs to eat all coins.
</pre>

<pre>
<p align="center">
  <img src="https://github.com/ValerieWang628/balance-ball/blob/master/snap/snap4.png" width="600" height="375">
</p>

The "sky scraper"-like building sets are actually traps for the player due to the limited jump acceleration. 
Once the ball falls into the hollowed areas, it might be hard to lift itself up.
There are many nuances of material, mass, force, etc.
Different settings for different parameters will cause huge difference in players' experience.
</pre>

<pre>
<p align="center">
  <img src="https://github.com/ValerieWang628/balance-ball/blob/master/snap/snap6.png" width="600" height="375">
</p>

This is a snake puzzle. The player will have to be comfortable with horizontal movements. 
After all, it would be annoying if the ball keeps falling to the ground when going through the snake.
</pre>


👉🏼Hovering view
<pre>
<p align="center">
  <img src="https://github.com/ValerieWang628/balance-ball/blob/master/snap/snap1.png" width="600" height="375">
</p>

I built 4 air walls around the playground preventing ball from going out of sight. 
In the game view, they look compeletely transparent.
</pre>



