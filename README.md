# DECO7381-Codenough

# Week 7 Snapshot

### Link for Trello board:

### https://trello.com/invite/b/kq2R14GD/ATTIb35c0f59cb16b88a35fa66e48371f49d647815FA/deco7381-weekly-journey

<img src="/images/trello.png" alt="Screenshot of the trello Board" title="Trello Board">

```
- Ruobing Wang
- Yushan Jiang
- Yiheng Wu
- Bosong Yu
- Zhiyuan Xiong
- Wang Zhang
```

In week 6, we assigned each member a task that goes through the whole project:

1. Use G29 to control the car (Physically mimics car movement, steering, acceleration, braking, etc.) - Wang
1. First-person perspective operation (Main responsibilities: first-person interface setting, steering wheel Angle as input, to ensure that the first person can successfully control the car and interface data interaction) - Yiheng
1. Vertigo operation (Main responsibilities: responsible for the vertigo effect of the screen, the change of operational attributes, as far as possible to imitate the real drunk driving human perspective). - Bosong
1. Scene construction (Main responsibilities: responsible for constructing roads, trees, and various scenes to ensure that objects can move successfully in the scene. - Eva (Yushan)
1. Obstacle setting and subsequent output (Main responsibility: make sure an object that hits an obstacle has an animation output and exits the game.) - Zhiyuan
1. User interface (Main responsibilities: UI interface, user interaction design. For example, users click different buttons to go to different interfaces, users click buttons to start any game and subsequent functions.) - Carrie (Ruobing)
1. Animation (Main responsibilities: Responsible for creating animations and scene designs that resonate with users.) - TBA

## In week 7 we have done so far:

## The primary <ins>UI menu </ins> has been completed below:

<img src="/images/UI.png" alt="The primary UI menu" title="UI basic">

## <ins>First-person perspective:</ins>

```
Simulate the G29 halfway through. The mirror effect on the car that right-hand driving got fixed
already. The future plan will be focused on car control and other relevant functions.

```

- Examined how to make the vehicle's kit change to right-hand drive.
  The Unity store sets are all left rudder, and there is no technique to recreate them. By taking the approach of mirroring the interior of the vehicle, the model is made to change to the right rudder.

- Bound the input actions to the animation of the steering wheel.
  Linking with the binding of G29 requires associating the input commands to the steering wheel animation as well as other operations.

### Future plan week 8:

If a new model was used, it would be beneficial to take the same approach to accomplish the same goal.

The script file needs to be modified to ensure proper functionality.

<img src="/images/image%20(1).png" alt="screensht inner car" title="screenshot inner">
<img src="/images/image.png" alt="first-perosn view" title="scrrenshot first perosn view">

## <ins>Obstacles with collision have nearly been done </ins>

- We have completed the collision effect between objects
- Set the trigger when the object collision effect has feedback.

### Future Plan Week 8:

- Create and play a video through a trigger
- Cars can realise collision effects. There is a limit to the number of collisions.

<img src="/images/Trigger.jpg" alt="screensht inner car" title="screenshot inner">
The image shows the object collision effect that uses 3D objects to simulate.

## <ins>Blur camera Setting<ins>

```
The blur camera is almost done. There may be some changes, such as the dizziness being relatively fast.
```

- We have set the effect of the main camera auto shake.
- Camera blur during the motion.

### Future plan week 8:

- Update the shader, which can allow the input to change.

The below images show the camera shaking and blur effect and code.

<img src="/images/code1.png" alt="screensht code" title="screenshot inner">
<img src="/images/shakescreen.png" alt="screensht camera effect" title="screenshot effect">

## <ins>G29 and Unity Connection<ins>

- G29 Connection - Successfully connect G29; all of the input can be shown with GUI in Unity.
- G29 Button - All of the buttons can have an output if the user presses any of them, and the information of each one can be located.
- Driving Effect - All effects can be set up before the game. Eg, Damper force.
- G29 Control a Car - Successfully using G29 to control a car.

### Future plan week 8:

- Add all functions to the car. Such as brake(), DecelerateCar ().
- User test - Test driving experience, like whether the user thinks it is easy to control.
- Add audio to the car.
- Combining all parts of us finished tasktogether.
- Figure out how to implement it in the First-person view.

<img src="/images/code.png" alt="screen code" title="screenshot G29 CONNECT  code">
<img src="/images/7381_week8_snapshot_UnityView.png" alt="screen result" title="screenshot G29 result connection">

## <ins>Ethics, security and data privacy</ins>

**a. Ethics:**

```
_Statement_:

Our team is committed to creating a responsible gaming experience that discourages drunk driving.
```

```

Responsible Gaming Disclaimer:

- In-game disclaimers and pop-ups explicitly state that the game is a simulation and does not endorse or encourage real drunk driving.

Example:

The responsible gaming disclaimer will be displayed prominently on the game's loading screen and in the main menu. It will state, "Play responsibly. Don't let the game influence real-world behavior. If you drink, don't drive."
```

```

Educational Pop-ups:

- Example:

Educational pop-ups will appear after each completed race within the game. These pop-ups will include statistics such as "Over 10,000 lives lost annually due to drunk driving" and a clear message stating, "This game is intended to raise awareness about the dangers of drunk driving. Please don't drink and drive in real life."
```

```

User Consent:
- Example:

During the game's initial setup, users will be presented with a consent dialogue box. It will explain that the game collects gameplay data for analysis and improvement. Users must check a box to provide their consent before proceeding with the game.

```

**b.Security (Okta):**

```
Statement: We prioritize the security of user data and the game's infrastructure.

Evidence:

- User data is securely stored and transmitted using industry-standard encryption protocols.

- Regular security assessments and penetration testing are conducted to identify and address vulnerabilities.

- Access controls and authentication mechanisms are in place to prevent unauthorized access to user data and game resources.
```

```
Authentication and Encryption (Attachment below):

Example:

User authentication will involve a two-factor authentication (2FA) system requiring a password and a one-time code sent to the user's email. User credentials and sensitive data will be encrypted using AES-256 encryption for both transmission and storage.

```

**c. Privacy**

```
Statement: User data privacy is a fundamental concern, and we adhere to strict data handling
policies.

Evidence:

- Users are explicitly asked for consent to collect gameplay data, and the purposes of data collection are clearly communicated.
- Anonymization techniques are employed to protect user privacy, with minimal personally identifiable information collected.
- A comprehensive privacy policy is accessible within the game, explaining how data is used, retained, and deleted upon request.

```

```
User Data Access and Deletion:

-Example:

Users can access their data by navigating to the "Settings" menu and selecting "Data Access." Requests for data deletion can be submitted through a "Delete My Data" button in the same menu. The team will respond to access requests within 48 hours and data deletion requests within 7 days.
```

```
Data Collection Transparency:

- Example:

The privacy policy accessible within the game will detail data collection practices. It will explain that data includes user profiles, gameplay statistics, and device information. The policy will clarify that data is used solely for game improvement and analytics.
```

# Week 11 Snapshot

In week 6, we assigned each member a task that goes through the whole project:

1. Combined user life icon to the final one

1. Made the after-survey for user test - Ruobing Wang

1. Process Bar (which changes with windows blur)

1.Game page UI ( Buttons : quit, stop, back )

1. Instructor induction page: Saturday discuss

1. Car performance improvement ability

1. Ui of Minimap frame
