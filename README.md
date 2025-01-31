# GameAI

## Description
A basic sample using the Unity AI Navigation package. This sample demonstrates the use of ProBuilder and prefabs for scene geometry with a navmesh used for Agent navigation. A rigidbody component is configured on Agents so that they can interact with debris in the scene. The navmesh and Agent settings are configured to allow the agents to assend stairs and ramps and to be able to fall off elevated areas when following the player. A single script called the AgentManager is in the scene which procedurally registers and updates the agents to follow the player.

## How To Play
1. Open the AI Navigation Sample Scene.
2. Press Play in Editor mode.
3. Use the arrow or AWSD keys to move the player, spacebar to jump, and hold shift to run.

## Functionality  
You can navigation around the scene and knock over debris. AI Agents will navigation toward you and can also knock over debris without it interferring with their navigation using built in Unity Physics.
