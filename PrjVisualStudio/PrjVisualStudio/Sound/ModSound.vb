Module ModSound




    Public Sub PlayDingSound()

        Try

            My.Computer.Audio.Play(".\Sound\Ding.wav", AudioPlayMode.Background)

        Catch ex As Exception

        End Try

    End Sub


End Module
