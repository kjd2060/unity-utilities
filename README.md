# unity-utilities
This repository keeps any c# unity code that would have applications across multiple games.

# Files
audiofade.cs - fades out sound volume to prevent clicking / popping when stopping an audio clip midway through.  Some amount of tuning towards your application is required in terms of fade length; I used .15f, which is short enough to be fairly unnoticeable but prevents most popping and deals with multiple audio starts in quick succession fairly well (e.g. audio is tied to a key, key is spammed).
