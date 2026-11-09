# CS077 Action 11B — From Story to Playable Scene

## My team decision and whiteboard plan
Roman Calles / https://github.com/BroMaan/CS077-2026/tree/main
Working solo
Void Runners story
The goal is to have the runner move and click the beacon have it become cyan.
I only brought my experience from 11A and I needed help connecting Unity to GitHub.
https://github.com/BroMaan/CS077-2026/tree/main/Week%2011/11B

## My scene and code connection
Unity / 6.6 / C#
Void Runners 11B / runner / beacon
The speed field stores my value, and the Speed property accesses it. The Update() method uses it to control the Runner's movement through controller.SimpleMove().
I used the code from the instructions.

## My package / using explanation
Unity Input System / 1.20.1
Unity Technologies / Unity Input System
Keyboard Input / Packages/manifest.json
UnityEngine.InputSystem
Imports namespace / Package Manager installs package
Reused Input System and supplied scripts
No error; Beacon reference was unassigned. Fixed in inspector.

## My test, improvement and team return
Runner moved correctly using WASD in multiple directions.
outside range: nothing happened, inside range: beacon turned cyan, repeated activation, the beacon stays cyan without activating again.
one changed value: changed speed to 5, predicted faster movement, higher speed increases movement velocity.
Promised a character that interacts with a story object, showed character interacting with beacon.
I learned more about the git and pushing process.
working solo, github, CS077-2026

This record contains my notes and declarations. It does not verify completion or establish a grade.
