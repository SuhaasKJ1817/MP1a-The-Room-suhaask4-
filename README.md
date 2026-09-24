### Intro to Extended Reality — MP1a

# 

##### A Unity 6 (6000.5.6f1) VR project built for the Intro to Extended Reality course, using OpenXR and the XR Interaction Toolkit. The scene is a 15×15×15 unit enclosed room featuring interactive controller-driven mechanics, orbital physics simulations, a custom outline shader, and a fully replaced skybox.

# 

### Requirements:

* ##### Unity 6000.5.6f1
* ##### Packages: OpenXR Plugin, XR Interaction Toolkit (with Starter Assets / Default Input Actions sample imported)
* ##### A VR headset supporting OpenXR (tested with Oculus Touch controller profile)



### Controls:

* ##### Left Trigger (Activate): Quit the application
* ##### Left Grip (Select): Teleport between the room and an external viewing platform
* ##### Right Trigger (Activate): Spawn an object (with particle burst, spatial sound, and an orbital trajectory around the Planet)
* ##### Right Grip (Select): Change the Point Light's color





### Features Implemented:

# 

#### View:

# 

* ##### Object Space — Moon is a child of Planet, moving together
* ##### World Space — a TextMeshPro Canvas mounted on a wall, fixed in world space rather than screen space
* ##### Materials — multiple custom materials (tiled stone with normal maps, flat color, metallic/smoothness variants) applied across walls and props
* ##### Highlight Outline — a custom two-pass HLSL vertex shader (inverted-hull technique) applied to the Comet
* ##### XR Tracked Camera — head-tracked via the connected headset

# 

#### World:

# 

* ##### Euler Steady — the Planet rotates every frame via Update() and Time.deltaTime, carrying the Moon in orbit
* ##### Kinematic Double Integrators — the Comet's acceleration is integrated into velocity, then velocity into position, each frame

# 

#### Execution:

# 

* ##### XR Controller Inputs — four distinct controller buttons mapped to distinct scripts
* ##### Quit Key, Object Spawning, Camera Teleport — see Controls table above

# 

#### User Feedback:

# 

* ##### Particle Bursts — a particle system is instantiated at the spawn location on every spawn
* ##### Spatial Sound — a 3D positional AudioSource (spatialBlend = 1) plays at the spawn location

# 

### Side Quests:

# 

1. ##### Object Shooter — spawned objects carry a velocity set to the controller's aim direction at spawn
2. ##### Arbitrary Orbiter — gravity pulls objects toward a reassignable attractor Transform rather than a hardcoded point
3. ##### Perfect Orbits — spawn velocity is corrected to remove the radial component and scaled to sqrt(gravity / distance) for a stable orbit
4. ##### Skybox Material — a custom 6-Sided skybox using provided sky13 textures
5. ##### Rainbow Lighting — the Point Light's color randomizes on button press

# 

### Content:

# 

1. ##### Object Content — 8 distinct decorative objects in the scene
2. ##### Material Content — 8 distinct materials applied across separate objects







