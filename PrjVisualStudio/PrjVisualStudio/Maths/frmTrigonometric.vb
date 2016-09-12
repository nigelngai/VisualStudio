Public Class frmTrigonometric

    Private Sub frmCalculation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim dblAdjacent As Double = 3
        Dim dblOpposite As Double = 4
        Dim dblHypotenuse As Double = 5

        Dim mySine As Double
        Dim myCosine As Double
        Dim myTangent As Double

        mySine = CalcSine(dblOpposite, dblHypotenuse)
        myCosine = CalcCosine(dblAdjacent, dblHypotenuse)
        myTangent = CalcTangent(dblOpposite, dblAdjacent)

        LblSineValue.Text = mySine
        LblCosineValue.Text = myCosine
        LblTangentValue.Text = myTangent

        'Returns the angle whose sine is the specified number.
        Dim mySineRadian As Double
        mySineRadian = Math.Asin(mySine)

        Dim myCosineRadian As Double
        myCosineRadian = Math.Acos(myCosine)

        Dim myTangentRadian As Double
        myTangentRadian = Math.Atan(myTangent)

        'Convert Radian to  Degree
        Dim mySineDegree As Double
        mySineDegree = ConvertRadianToDegree(mySineRadian)
        Dim myCosineDegree As Double
        myCosineDegree = ConvertRadianToDegree(myCosineDegree)
        Dim myTangentDegree As Double
        myTangentDegree = ConvertRadianToDegree(myTangentDegree)

        'Present Value
        labelSineResult.Text = ConvertRadianToDegree(mySineRadian)
        labelCosineResult.Text = ConvertRadianToDegree(myCosineRadian)
        labelTangentResult.Text = ConvertRadianToDegree(myTangentRadian)




        Dim mySOHValue As Double
        Dim dblOppositeLength As Double

        'Input AngleInDegree
        'labelSineResult.Text is 53.13......  ( dblOpposite / dblHypotenuse )
        lblDegree.Text = labelSineResult.Text

        mySOHValue = Math.Sin(Math.PI * lblDegree.Text / 180)
        lblSOH.Text = mySOHValue

        'mySOHValue = Opposite / Hypotenuse
        '0.8 = Opposite / 5

        lblHypo.Text = 5
        dblOppositeLength = 5 * mySOHValue

        lblOpposite.Text = dblOppositeLength


    End Sub

    Private Function CalcSine(dblOpposite As Double, dblHypotenuse As Double) As Double
        'SOH
        CalcSine = dblOpposite / dblHypotenuse
    End Function

    Private Function CalcTangent(dblOpposite As Double, dblAdjacent As Double) As Double
        'TOA
        CalcTangent = dblOpposite / dblAdjacent
    End Function

    Private Function CalcCosine(dblAdjacent As Double, dblHypotenuse As Double) As Double
        'CAH
        CalcCosine = dblAdjacent / dblHypotenuse
    End Function


    Private Function ConvertRadianToDegree(dblAngle As Double) As Double
        Return dblAngle * (180.0 / Math.PI)
    End Function


    Private Function ConvertDegreeToRadian(dblAngle As Double) As Double
        Return Math.PI * dblAngle / 180.0
    End Function



End Class