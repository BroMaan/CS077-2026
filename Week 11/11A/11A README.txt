11A README

1. The three class definitions are ChangeObjectColor, RotateObject, and TranslateObject. Two instances could be two different Unity GameObjects, each with these components attached. Each instance has its own data, such as tint, degreesPerSecond, and speed, with values that can differ between the two objects.

2. Field: private float speed = 1f; – Stores the object's movement speed.
Property: public float Speed – Provides access to the private speed field.
Getter: get { return speed; } – Returns the current movement speed.
Setter: set { speed = value; } – Changes the movement speed.
Method: Update() – Runs every frame and moves the object to the right based on its speed.

3. Update(): Runs once every frame and executes the movement code.
Speed getter: Retrieves the object's current movement speed.
Translate(): Moves the object to the right using Vector3.right * Speed * Time.deltaTime.
Changed Transform: Unity updates the object's position in the scene.
Rendered Image: Unity renders the scene with the object in its new position.

4. The Tint property only changes the tint variable, but the object's material color is only updated once in the Start() method. To make color changes happen immediately during Play, you would need to update runtimeMaterial.color = tint in the Update() method or inside the Tint setter.

5. The three components (`ChangeObjectColor`, `RotateObject`, and `TranslateObject`) demonstrate composition because they work together on one GameObject, each providing a different behavior. Inheritance appears when each class uses `: MonoBehaviour`, meaning it inherits functionality from Unity's `MonoBehaviour` class.

Movement:
starting position: (0, 2, 0)
position after 3 seconds: (7.7, 2, 0)

Rotation:
starting rotation: 0 degrees
after: -123 degrees

Color:
Script sets the color on start.



