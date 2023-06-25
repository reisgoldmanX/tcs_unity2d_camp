# Day 3: 2D Collision and Coin Collection

## Section 1: Exploring 2D Collision and Collecting Coins

In this section, we will dive deeper into 2D collision detection and explore how to collect coins in our game.

### Collision Detection in Unity

Unity provides a robust collision detection system that allows objects to interact with each other. To enable collision detection, we need to set up colliders for our game objects.

1. Select the game object you want to add a collider to.
2. In the **Inspector Window**, click the **Add Component** button.
3. Search for and select the appropriate collider component based on the shape of your object. For example, you can use a **Box Collider 2D** for rectangular objects or a **Circle Collider 2D** for round objects.
4. Adjust the collider's size and position to match the shape and size of your object.

### Collecting Coins

To create a system for collecting coins in our game, we need to follow these steps:

1. Create a script to handle the coin collection logic. Let's name it `CoinCollector.cs`.

2. Attach the `CoinCollector` script to the game object that represents the player character.

3. In the `CoinCollector` script, add the necessary variables:

   ```csharp
   using UnityEngine;
   using UnityEngine.UI;

   public class CoinCollector : MonoBehaviour
   {
       public int coinCount = 0;
       public Text coinText;
   }
   ```

   - The `coinCount` variable keeps track of the number of collected coins.
   - The `coinText` variable is a reference to a UI text component that will display the coin count on the game scene.

4. Implement the coin collection logic in the `CoinCollector` script. Add the following code:

   ```csharp
   void OnTriggerEnter2D(Collider2D other)
   {
       if (other.CompareTag("Coin"))
       {
           Destroy(other.gameObject);
           coinCount++;
           UpdateCoinText();
       }
   }

   void UpdateCoinText()
   {
       coinText.text = "Coins: " + coinCount.ToString();
   }
   ```

   - The `OnTriggerEnter2D` method is called when the player's collider enters a trigger collider attached to a coin.
   - We check if the collider belongs to a coin using the `CompareTag` method.
   - If it is a coin, we destroy the coin object, increment the `coinCount`, and update the coin count text using the `UpdateCoinText` method.
   - The `UpdateCoinText` method updates the coin count text by setting the `text` property of the `coinText` UI component.

Now, when the player character collides with a coin, the coin will be collected, the coin count will be updated, and the coin count text on the game scene will reflect the current count.

## Section 2: Updating Coin Count Text

In this section, we will update the coin count text on the game scene to display the current number of collected coins.

### Displaying Coin Count

To display the coin count on the game scene, follow these steps:

1. Create a UI text object to show the coin count. If you haven't already, create a Canvas object in your scene.

2. Inside the Canvas, create a Text object or use an existing one.

3. Assign the Text object to the `coinText` variable in the `CoinCollector` script.

   ```csharp
   public Text coinText;
   ```

4. In the `UpdateCoinText` method of the `CoinCollector` script, modify the code to set the coin count text:

   ```csharp
   void UpdateCoinText()
    {
        coinText.text = "Coins: " + coinCount.ToString();
    }
   ```

Now, when the player collects coins, the coin count text on the game scene will update accordingly, displaying the number of coins collected.

Remember to test your game and ensure that the coin collection and coin count text updates are working as expected.

Great job! You've now learned how to handle 2D collision detection and implement coin collection mechanics in your game, along with updating the coin count text on the game scene.


## Section 3: Respwan Script
