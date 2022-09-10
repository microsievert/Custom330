# Custom 330 (v1.0.1)
> This plugin adds the ability to customize the actions of any candy presented in the game. **The plugin is ready to work with Exiled 5**

## Plugin configuration setup examples
### Overriding candy effect
```yml
better330:
  is_enabled: true
  effects_override:
    Red: # Candy for that you want override effects 
      is_overridden: true # Remove default effects?
      damage: 0 # Damage that will be applied to player after eating candy
      regeneration: 0 # Health points that will be added to player after eating candy
      ahp_shield: 0 # Ahp points that will be added to player after eating candy
      notice_time: 6 # Time while hint will be visible
      notice: <b>Wow. Good.</b> #If you don't want to use hints just set empty string.
      apply_effects: # Effects data list
      - time: 0.2 # Effect time
        delay: 0 # The time after which this effect will be applied after eating the candy
        intensity: 1 # Effect intensity
        effect: Flashed # Effect type
      remove_effects: # Effects that will be removed after eating candy
      - Amnesia
      - Hemorrhage
      - Corroding
```

## Plugin Installation
> Download last release on releases page and put Custom330.dll into ``EXILED/Plugins/`` folder. Goodluck!
