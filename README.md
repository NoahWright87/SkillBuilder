# Skill Builder
Proof of concept of a skill building system that would allow players to create new skills on the fly in an RPG game.

**Current State:**
- Retrieved in-progress code from an old external hard drive
- Creating this repository 

## The Problem
I've played so many games with so-called "crafting systems" that don't actually let me *craft*.  More often than not, these systems are what I call "recipe discovery systems", not crafting.  What I mean by that is that somebody, while making the game, decided that Item A + Item B = Item C.  If they didn't have an idea for what Item A + Item C would create, you can't do it.  Many times you, the player, has a theory about what two items will produce, only to find out that either A) the two items can't be combined or B) your idea doesn't match the designer's idea.  While some people are perfectly fine with discovering recipes, it always leaves me disappointed.

While griping about **The Problem**, I exclaimed that - if you did it right - you could create a robust crafting system and base an entire game around it.  "Craft your own weapons, craft your own gear, heck, even craft your own skills!" I exclaimed to some skeptical friends.  They argued that creating an easy-to-use system that the end user could utilize to craft their own skills just couldn't be done.  I disagreed.

## The Solution
The basic idea is that all skills is made up of a series of smaller parts.  As I looked through stereotypical RPG skills, I started to break them down into their parts.  For example:

**Exploding Fireball:**
- Throw magic projectile
  - Made of fire
- On impact...
  - Spawn area of effect
    - Made of fire

Pretty simple, right?  Or you could just go crazy with skills pieces, like so:

**Charged, Exploding, Fragmenting Fireball with Poison Gas-filled Dummy**
- Charge up your shot
- Release your charge
  - Player is moved
    -  Opposite direction of the shot
    -  Further based on charge
  - Dummy copy of Player is spawned
    - That creates AoE when destroyed
      - That is sustained
      - That is made of poison
      - That is bigger based on charge
  - Launches a magic orb
    - That is bigger based on charge
    - Made of fire
    - Leaves a trail
      - Made of fire
    - On impact
      - Spawn area of effect
        - Made of fire
      - Launch 3 projectiles
        - Aimed at nearby enemy
        - Made of fire

Suddenly, things get *really, really complicated*.  So how do you make this usable?  Eventually, the goal is for this to be a drag-and-drop system where each piece is keyed to work properly with certain other pieces.  In other words, the pieces would look like jigsaw puzzle pieces.  Using the above examples, the magic projectile could have notch on one side that fits perfectly with various elemental pieces, allowing you to create a fireball, iceball, etc.  The initial proof of concept will be to have these puzzle pieces be turned into a sentence that describes the skill.  I see the pieces themselves representing nouns and adjectives (magic ball, fiery, sharp, etc), and the connectors between them will become connecting words (on impact, while in motion, when destroyed, etc).  Eventually, instead of a sentence, this could be turned into an animation in a game engine. 

If the *player* can create skills out of pieces, what's to stop the *enemies* from having procedurally generated skills?  Even better, what if you got skill pieces by defeating an enemy that uses it?  You fight a powerful enemy with some really impressive attacks, and when you're done, now **you** can create similar attacks.  Suddenly all your loot turns into crafting possibilities, and the room for innovation grows as the progress further and further.

To keep things from becoming too overwhelming too quickly, I would suggest one thing: skills would need to have a limited "complexity" (i.e.: total number of pieces) that raises as a player gets further into the game, levels up, or otherwise progresses.  Also, skills should have exponentially higher costs as they increase in complexity.  Every magical element should increase the MP cost, and every physical element should increase the HP or stamina cost.  This would add another layer of thought when creating skills and should hopefully stop people from creating cheesy, game-ruining skills.  

## What about Passives?
This is all fine and good for active skills, but can it work for passives abilities?  Where skills are triggered by a button press, passives are triggered by other things.  Those triggers could create effects, just like active skills.  What sorts of triggers exist?  Here are some examples:

- All the time
- When hit
- When out of danger for X seconds
- When attacking
- While in motion
- On a successful dodge

Obviously, some of these are more likely to happen than others.  To balance things, harder-to-activate triggers should have a corresponding increase in the effects of the ability.  For example, a passive healing effect shouldn't be nearly as effective as healing that triggers when out of danger.
