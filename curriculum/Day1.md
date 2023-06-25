# Day 1: Unity Basics

## Section 1: Understanding Scenes and Unity Editor

### What is a Scene?
In Unity, a **scene** represents a specific level, environment, or menu within a game. It acts as a container for all the objects, assets, and components that make up a particular part of your game. Each scene can have its own unique settings, such as lighting, camera positions, and gameplay elements.

### Unity Editor Overview
The **Unity Editor** is the primary tool used to create, modify, and organize scenes and game assets. It provides a visual interface where you can manipulate objects, adjust properties, and build your game world. The key elements of the Unity Editor are:

- **Hierarchy:** The **Hierarchy** window displays a list of all the objects present in the current scene. Objects can be organized hierarchically, forming parent-child relationships. This window allows you to select, rename, and manipulate objects within the scene.

- **Scene View:** The **Scene View** provides a visual representation of the current scene. Here, you can navigate and explore your game world, position objects, and adjust their properties.

- **Inspector:** The **Inspector** window displays the properties and components of the currently selected object. You can use this window to modify the object's attributes, such as position, rotation, scale, and add or remove components.

- **Project Window:** The **Project Window** shows all the assets (e.g., scripts, textures, models) present in your project. You can import, create, organize, and manage these assets within this window.

### Understanding Cameras
In Unity, a **camera** is a crucial component that captures the scene and renders it onto the screen. It acts as the player's viewpoint within the game world. The camera determines what is visible to the player and how the scene is displayed.

The **Camera** component has various properties, including **Field of View (FOV)**, which determines the extent of the scene captured by the camera, **Clipping Planes**, which define the near and far distances at which objects are visible, and **Background Color**, which sets the color displayed when no objects are visible.

## Section 2: Adding and Transforming Objects in the Scene

### Adding a Square to the Scene
To add an object to the scene, follow these steps:

1. In the Unity Editor, select the desired scene in the **Project Window** or create a new one.
2. Right-click in the **Hierarchy** window and choose "Create Empty" or select an existing GameObject to use as a parent.
3. Right-click the created object in the **Hierarchy** window, go to **2D Object**, and select **square** or **capsule** depending on the desired shape.

### Transforming Objects: Position, Rotation, and Scale
After adding an object to the scene, you can manipulate its position, rotation, and scale using the **Transform** component. The **Transform** component defines the object's spatial attributes.

- **Position:** The position determines the object's location in the scene, represented by the X, Y, and Z coordinates. You can modify the position values in the **Inspector** window or directly manipulate the object in the **Scene View**.

- **Rotation:** The rotation determines the object's orientation in the scene. You can adjust the rotation values for the X, Y, and Z axes in degrees. Rotation values can be modified in the **Inspector** window or using rotation handles in the **Scene View**.

- **Scale:** The scale determines the object's size in the scene. It consists of X, Y, and Z scale factors. Modifying the scale values can resize the object in the respective dimensions.

## Section 3: Colliders and Ridigbody

### Introduction to Colliders
Colliders are components used to define an object's physical shape and interaction with other objects in the game world. They are essential for enabling collision detection and response. In Unity2D, the **Box Collider 2D** and **Polygon Collider 2D** are commonly used for 2D objects.

By attaching a collider to an object, it gains a physical presence and can interact with other colliders in the scene. Colliders allow for collision detection, triggering events, and implementing physics-based behaviors.

### Rigidbody2D Component
The **Rigidbody2D** component is used to simulate physics-based movement and interactions for 2D objects. By attaching a Rigidbody2D to an object, you can control its mass, gravity, and apply forces or impulses to make it move.

The Rigidbody2D component works in conjunction with colliders to provide realistic physics behavior. It calculates collisions and applies forces based on the object's interactions with other colliders.

When using Rigidbody2D, you can control the object's movement by applying forces or directly modifying its velocity or position.

Remember to set the appropriate collision detection mode and configure physics materials to fine-tune the behavior of colliders and Rigidbody2D interactions.

By understanding the concepts covered in this section, you have gained a solid foundation for creating and manipulating objects within Unity, as well as setting up basic physics interactions using colliders and Rigidbody2D components.

Continue exploring Unity to further expand your knowledge and skills in game development!

## Section 4: Playing with basic Physics
In this section, we will add two 2D squares to the scene and configure their properties.

### Adding the "Ground" Square
1. Right-click in the **Hierarchy** window and select "Create Empty" to create a new empty GameObject.
2. Rename the GameObject to "Ground".
3. Right-click the "Ground" GameObject, go to **2D Object**, and select **Sprite**. This adds a Sprite Renderer component to the object.
4. In the **Inspector** window, click the circle next to the **Sprite** field and select a sprite or image to use as the ground texture.
5. Adjust the position, rotation, and scale of the "Ground" square as desired using the **Transform** component in the **Inspector** window.
6. Add a **Box Collider 2D** component to the "Ground" GameObject by clicking the **Add Component** button in the **Inspector** window and selecting **Physics2D** > **Box Collider 2D**.
7. Add a **Rigidbody2D** component to the "Ground" GameObject using the same **Add Component** button and selecting **Physics2D** > **Rigidbody2D**.
8. Configure the properties of the **Rigidbody2D** component as needed. For now, you can leave the default settings.

### Adding the "Box" Square
1. Follow the same steps as above to create a new empty GameObject.
2. Rename the GameObject to "Box".
3. Add a **Box Collider 2D** component to the "Box" GameObject.
4. Add a **Rigidbody2D** component to the "Box" GameObject.
5. Configure the properties of the **Rigidbody2D** component:
   - **Gravity Scale**: Adjusts the strength of gravity applied to the object. A value of 0 means no gravity, while higher values increase the effect of gravity.
   - **Mass**: Determines the object's resistance to changes in velocity caused by forces. A higher mass value means the object is harder to move.
   - **Body Type**: Defines how the object interacts with physics simulations. Choose between:
     - **Static**: Object does not move or respond to physics forces.
     - **Dynamic**: Object can move and is affected by forces.
     - **Kinematic**: Object can move but is not affected by external forces. It can be controlled programmatically.

Feel free to experiment with different properties and values to observe the effects on the "Ground" and "Box" squares. This will help you understand the impact of gravity, mass, and body type on the Rigidbody2D behavior.

Remember to save your scene and test the interaction between the objects and their colliders.

## Section 5: Exploration and Experimentation Time

Congratulations on reaching this point! In this section, we encourage you to give time to the kids to play around, explore, and experiment with the concepts they have learned so far. This open-ended session allows them to discover new possibilities, observe patterns, and gain hands-on experience.

Here are some suggested activities for the kids during this exploration time:

1. **Object Manipulation**: Encourage the kids to experiment with manipulating the position, rotation, and scale of objects in the scene. They can observe how these transformations affect the object's appearance and behavior.

2. **Collisions and Interactions**: Encourage the kids to place objects in close proximity and observe the collision behavior. They can discover how colliders interact with each other and how objects respond to collisions.

3. **Physics Simulations**: Kids can experiment with adjusting the properties of the Rigidbody2D component, such as mass, gravity scale, and body type. They can observe the effects of these changes on object movement and interactions.

4. **Creative Challenges**: Pose creative challenges or scenarios for the kids to solve using the concepts they have learned. For example, challenge them to create a seesaw using a Rigidbody2D object and experiment with adding weights to one side to achieve balance.

5. **Pattern Recognition**: Encourage the kids to identify patterns or similarities they notice among different objects or components. They can discuss and share their observations, fostering collaboration and critical thinking.

Remember to provide guidance, answer questions, and facilitate discussions during this exploration time. It is an opportunity for the kids to apply their knowledge, gain a deeper understanding, and have fun while doing so.

Enjoy this playful and discovery-filled session, and encourage the kids to share their findings and experiences with the group!

## Section 6: Videos to watch
[Hollow Knight](https://www.youtube.com/watch?v=UAO2urG23S4)

[Ori and the Blind Forest](https://www.youtube.com/watch?v=cklw-Yu3moE)

[Monument Valley 2](https://www.youtube.com/watch?v=tW2KUxyq8Vg)
