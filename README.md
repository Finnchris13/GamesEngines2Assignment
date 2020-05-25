# GamesEngines2Assignment
 A recreation of the Voyager Vs. Kazon fleet battle in Star Trek: Voyager.
 
 The assignment is a recreation of a Youtube video featuring a starship fight scene from Star Trek: Voyager.
 The project goes in between scenes from Star Trek and scenes I recreated in unity. All of it takes place in Unity, including the scenes from Star Trek which I used the videoplayer to implement.
 
 I built the project around how it looks in builds, not in unity editor, so some things in the editor might look a little off due to how it looked in the builds I made. It should still work fine in editor. All you have to do is play the build and hit the start scene button to get the scenes flowing. For the editor its the same, but just make sure to play the project while the menu scene is selected to go from the beginning.
 
 The project takes advantage of Unity scene management and the video player to jump in between scenes with dialogue and scenes with space ship fighting. All together there are about 13 scenes, 2 scenes being the start and end screens. The other 11 scenes consist of the recreation. I chose to use scenes to jump from dialogue to action as it allowed me to set up the next action scene without massive jumps in camera angle/position and spaceship positions. In the scenes with the action, the videoplayer alpha is set to 0 and the audio comes from the hidden video playing. I did this so I could just trim the whole video bit by bit and stitch it back together throughout the scenes in order to have as little issues as possible with the fluidity of project and scenes..
 
 I am not really sure what I am most proud of in this assignment but if I had to choose something I would say the scene in which the camera aims at the ship while firing photon balls (the orange balls). I enjoyed making this scene in particular because it required some in depth videoplayer management and UI stuff. It was definitely the funnest scene to work on and I believe it looks well although the explosions when the balls hit the ship just would not work.
 
 I wrote all scripts myself except for the big boid and path script which I got from class. I had to look up unity online to familiarise myself with the videoplayer so I could make the script for the dialogue scenes.
