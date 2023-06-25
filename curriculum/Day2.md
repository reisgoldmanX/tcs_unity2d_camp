# Day 2: Adding Assets and Introduction to Input Manager

## Section 1: Adding Assets to the Game

In this section, we will focus on adding assets to our game to enhance its visual and audio aspects.

### Importing Assets
To import assets into your Unity project, follow these steps:

1. Locate the desired assets (e.g., images, audio files, 3D models) on your computer.
2. In the Unity Editor, navigate to the **Project Window**.
3. Right-click in the desired folder within the **Project Window** where you want to import the assets.
4. Select **Import New Asset** or **Import Folder** to import individual files or entire folders, respectively.
5. Browse and select the assets you want to import.

### Organizing Assets
It is important to keep your assets organized to maintain a structured project. Consider creating appropriate folders within the **Project Window** to categorize and store different types of assets, such as **Textures**, **Audio**, **Models**, etc.

### Applying Assets to Objects
Once imported, you can apply assets to objects within your scene. For example:

1. Select the object to which you want to apply an asset.
2. In the **Inspector Window**, locate the component that requires the asset (e.g., **Sprite Renderer**, **Audio Source**).
3. Use the provided fields or options within the component to assign the imported asset.

Ensure that you properly configure the assets' properties and settings according to your game's requirements. Experiment with different combinations and observe the visual and audio effects within the scene.

## Section 2: Introduction to Input Manager

The **Input Manager** is a powerful system in Unity that allows you to handle user input, such as keyboard, mouse, touch, or gamepad input. It provides a unified interface for accessing and responding to user actions within your game.

### Input Manager Configuration
To configure the Input Manager, follow these steps:

1. In the Unity Editor, go to **Edit** > **Project Settings** > **Input**.
2. The Input Manager window will open, displaying a list of input axes.
3. You can modify the existing input axes or create new ones based on your game's needs.
4. Each input axis has properties like **Name**, **Positive Button**, **Negative Button**, **Gravity**, **Dead**, **Sensitivity**, and more. Adjust these properties to define how the input is recognized and processed.

## Section 3: Introduction to C# Scripting for Unity 2D Game Development

In this section, we will delve into the basics of C# scripting and its application in Unity 2D game development. Scripting allows you to bring interactivity, logic, and behavior to your game objects.

### Creating and Attaching Scripts
To create a new C# script in Unity, follow these steps:

1. In the Unity Editor, navigate to the **Project Window**.
2. Right-click in the desired folder or directory.
3. Select **Create** > **C# Script**.
4. Provide a name for your script and press Enter.

To attach a script to a game object:

1. Select the game object in the **Hierarchy Window** or **Scene View**.
2. In the **Inspector Window**, click the **Add Component** button.
3. Type the name of your script in the search bar and select it from the dropdown list.

### Script Anatomy
A C# script in Unity consists of various elements. Let's explore the basic structure and key components:

```csharp
using UnityEngine;

public class MyScript : MonoBehaviour
{
    // Variables and fields

    private int myVariable = 10;
    public float speed = 5.0f;

    // Methods

    void Start()
    {
        // Initialization code
    }

    void Update()
    {
        // Code executed every frame
    }
    
    // Additional methods, functions, and event handlers
}
```

- **Using Statements:** The `using` directive imports namespaces to access Unity's classes and functions.

- **Class Definition:** The class name should match the script file's name. It inherits from `MonoBehaviour`, allowing the script to be attached to game objects.

- **Variables and Fields:** Declare and define variables and fields to store data and state information. They can have different access modifiers (`private`, `public`, etc.).

- **Methods:** The `Start()` method is called once when the script is enabled, typically used for initialization. The `Update()` method is called every frame and is commonly used for continuous actions or interactions.

### Scripting Examples
Let's explore a couple of simple scripting examples:

#### Example 1: Moving Script

```csharp
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float speed = 5.0f;
    public Rigidbody2D player_physics;
    void start()
    {

    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontalInput, verticalInput) * speed * Time.deltaTime;

        player_physics.velocity = movement;
    }
}

```

In this script, we introduce the use of a `Rigidbody2D` component to control the movement of the object. The playerPhysics variable is a reference to the attached `Rigidbody2D` component.

During each frame update, we retrieve the `horizontal` and `vertical` input values from the player using `Input.GetAxis()`. We then calculate the movement vector by multiplying the input values by the speed and `Time.deltaTime` to ensure consistent movement regardless of frame rate.

Finally, we set the velocity property of the `Rigidbody2D` component to the calculated movement vector. This causes the object to move smoothly in a 2D space based on the player's input.

Make sure to attach this script to a game object with a `Rigidbody2D` component for it to work correctly.


#### Example 2: Detecting Collisions

```csharp
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Handle collision with an enemy
            Destroy(gameObject);
        }
    }
}
```

In this script, we define a collision detection method `OnCollisionEnter2D()`, which is called when a collision occurs with another collider. We check if the colliding object has a specific tag, in this case, "Enemy". If the condition is true, we handle the collision by destroying the object to which this script is attached.


## Conclusion
In Day 2, we focused on adding assets to our game to enhance its visual aspects. We also introduced the Input Manager, a powerful tool for handling user input in Unity. By applying assets and utilizing the Input Manager effectively, you can create more interactive and engaging gameplay experiences.

Continue to explore the possibilities of asset integration and user input in Unity to further enhance your game's design

 and functionality.
