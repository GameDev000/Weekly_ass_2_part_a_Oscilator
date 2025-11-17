# Weekly_Assignment_2_Part_A_Oscillator

### What this project is
This Unity task introduces a custom component called **Oscillator**, which moves a GameObject back and forth like a pendulum.  
The object smoothly moves to one side until it reaches a defined limit, then gradually slows down, stops, and reverses direction — repeating this motion continuously.

The center of the oscillation is the **object’s initial position** in the scene.  
For example, if the object starts at position (3, 2), it will move left and right around that point.

---

### How it works
The movement speed changes **gradually**, simulating realistic acceleration and deceleration like a real pendulum.  
This smooth, cyclic motion is achieved by using a **trigonometric function** such as sine or cosine, which defines the object’s position as a function of time.

The component is designed to be **general and reusable**, with public variables exposed in the Unity Inspector for easy customization.

---

### Adjustable parameters
- **Direction** – The direction of oscillation (horizontal, vertical, or any custom vector).  
- **Amplitude** – The distance the object moves away from its center position.  
- **Speed** – Controls how fast the oscillation occurs.  

By adjusting these parameters, you can easily create different oscillation behaviors for various objects.

---

### Demonstration
Attach the **Oscillator** script to several GameObjects in the scene, each with different values for direction, amplitude, and speed.  
When you run the game, each object will move in its own smooth, pendulum-like motion, centered around its original position.

<a href="https://itamar-raz-dev-game.itch.io/weekly-ass-2-part-a-oscilator">itch.io</a>
