_~blatantly stolen~ adapted from https://gist.github.com/AdamSheaffer/ec09a8b8a1edabbfc4d2ca7f8719abd7_

# Classy Electronics

You've just started working for a boutique electronic company and you've been tasked with modeling their new line of record players.

### Step 1: 

The company's most basic product line is simple turntables that
can support rpm speeds of 33, 45, and 78
Create a TurnTable class with these properties and methods:

##### Properties
- A **double** called `CurrentSpeed`
- A **boolean** property called `IsPlaying ` that tracks whether the motor is running
##### Methods
- An `Play` method that sets the `IsPlaying` property to `true`
- A `Stop` method that sets the `IsPlaying` property to `false`


### Step 2:

The company has decided to start a line of integrated turntables.
They'd like a new product that has speakers built right into the record players
This product has the same turntable built in, so create a subclass of Turntable
with these additional properties and Methods:

##### Properties
- An **int** called `Volume`
##### Methods
- A method called `VolumeUp` that increments `Volume` by 1
- A method called `VolumeDown` that decrements `Volume` by 1


### Step 3:

Research has shown that these all-in-one record players are a big hit. The company
wants to introduce a new product. It still has the turntable and speakers, 
but this time they want to have a built in AM/FM radio. Create a subclass of your
previous class with the following properties and methods:

##### Properties
- A **double** called `CurrentFrequency`
- A **List of doubles** called `FavoriteStations`
- An **Boolean** called `IsRadioOn`
##### Methods
- A method called `AddFavorite` that adds a new station to `FavoriteStations`
- A method called `RemoveFavorite` that removes a station from `FavoriteStations`
- A method called `TurnRadioOn` that sets `IsRadioOn` to `true`
- A method called `TurnRadioOff` that sets `IsRadioOn` to `false`

### Step 4:

Surprisingly many of the customers of this boutique electronic company really love listening 
to NPR - a lotta Steve Inskeep fans out there. Unfortunately, a heavy record player is a bit too 
bulky to carry out onto the veranda. What they really want is a radio with speakers, but _without_ 
the turntable. How can we make this happen?

### Step 5:

Our company needs to test it's products. We'd like to test in bulk. We have two specialized quality control
teams. One for turntables and one for radios. Create two methods `TestTurnTables`
that accepts a list of turntables, and `TestReadios` that accepts a list of radious. These methods
should exercise the features of each type of device.

> **Note** Some objects will need to be tested by each team.