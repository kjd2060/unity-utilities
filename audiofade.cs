    // Use StartCoroutine(VolumeFade(audioSource, endTime, fadeLength)); to run this.  will fade volume of a sound when used.  Prevents audio
    // popping when stopping in the middle of an audio clip.
    // some numbers that worked for me were endTime = 0f, fadeLength = .15f
    IEnumerator VolumeFade(AudioSource _AudioSource, float _EndVolume, float _FadeLength)
    {
        //print("fading volume");
        float _StartVolume = _AudioSource.volume;

        float _StartTime = Time.time;

        while (Time.time < _StartTime + _FadeLength)
        {

            _AudioSource.volume = _AudioSource.volume + ((_EndVolume - _StartVolume) * ((Time.time - _StartTime) / _FadeLength));

            yield return null;
        }

        if (_EndVolume == 0f) {
            _AudioSource.Stop();
            //_AudioSource.volume = _StartVolume;
            //print("end==0");
        }

    }
