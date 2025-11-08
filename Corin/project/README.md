<html>
<head>
</head>
<body>

<h1> try and try and try again </h1>
<h2> Brief description of game and objective </h2>
<p> The game would revolve around multiple runs to get a higher score based on your performance within the game. The game would be a platformer comprised of several procedurally generated rooms which get increasingly harder the longer you go, your score is based on how many rooms you clearly and how long your run was, if you clear lots of rooms very slowly you could still get a lower score then someone who clearly slightly less rooms in a shorter amount of times, within each room you could fight enemies which would drop items based on a loot table these items are stored at the end of your run and can be used to purchase upgrades for later runs that help you survive, better luck (easier rooms and better loot table drops) and speed, after a set number of rooms you would get enter a boss room (every 15 or so rooms) and bosses will random powerful items that can only be used for your current run and disappear after the run ends. </p>

<h2> 🚫 Challenges faced </h2>
<p> Within the process of developing my game I faced multiple challenges. When I began development, I initially began developing my game as a platformer. During this stage of development I was able to implement basic movement, jumppads, created a platforming landscape in which the player may traverse and was working on implementing enemies, a random loot table and a win screen at the end of the level. It was however at this point in development that all of the game's hierarchy was clearly likely due to either an error while committing or myself making a mistake while attempting to commit, if for this reason that I do not have any current footage of this stage of development. </p>

I also believe that while designing the game at this stage of development I was having some minor issues with developing the drop table system as there were several issues implementing the sprites I had developed into the drop table in unity, I was attempting to solve this when my progress was removed. </p>

<h2> 👊 Enemies </h2>
<p> The game would have a small group of enemies that spawn at random amounts in rooms; most rooms will often spawn multiple enemies of the same type at one time (likely using a series of if statement systems with a random chance for the additional amount, if enemy spawns there is a ten percent chance a second enemy spawns and so on). And you will be able to progress through to the next room after a certain number of enemies have been defeated. There would likely be a couple different kinds of enemies with different tracking styles and ways of attacking the player: </p>


<ul>
<li>with a simple enemy that simply follows the player. And deals damage on contact</li>

<li>An enemy designed to back up away from the player and throw projectiles</li>

<li>And a stronger enemy that will only follow the player if the player is over a certain distance and can block attacks and the player needs to time attacks to deal damage. </li>
</ul>

<h2> Loot system </h2>
<p> Each enemy has an assigned drop table so that after their health is reduced to zero they will drop a random item based on their drop table which would have a small list of potential items that can be dropped by that enemy with a percentage chance associated (eg: 12% 50% etc).</p>

<h2> 🔜 Goals from this point onwards </h2>
<ul>
<li> Reintroduce all lost content.</li>
<li> Implement enemies with differing tracking. </li>
<li> Add a drop table for each enemy. </li>
<li> Implement procedurally generated rooms. </li>
<li> Add upgrades. </li>
</ul>

<h2> Mechanics </h2>
<p> The player would start with movement, jumping and basic attacks but through upgrades could gain additional abilities such as double jumping and dashes for further runs.</p>

<h2>🎮 Inputs (designed for Xbox) </h2>
<table>
  <tr>
    <th>action</th>
    <th>output</th>
  </tr>
  <tr>
    <td>left joystick</td>
    <td>movement, all directions</td>
  </tr>
  <tr>
    <td>A button</td>
    <td>jump</td>
  </tr>
  <tr>
    <td>X button</td>
    <td>swing sword</td>
  </tr>
  <tr>
    <td>Y button</td>
    <td>interact</td>
  </tr>
  <tr>
    <td>LB/RB</td>
    <td>cycle between inventory</td>
  </tr>
  <tr>
    <td>RT</td>
    <td>use item</td>
  </tr>
  <tr>
    <td>LB</td>
    <td>dash</td>
  </tr>
</table>

</body>
</html>


