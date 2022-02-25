$ErrorActionPreference = 'Stop'

pwd

Function Invoke-Build 
{
	param ($config, $name)

	$program = "../../../$name/Program.cs"
	./QuineBuilder.exe $name > $program
	cp $program "$name-in.cs"

	$path = "../../../$name/bin/$config/$name.exe"
	if (Test-Path $path)
	{
		cp $path .
		Set-Content -Path "$name-out.cs" -Value $(& $path) -Encoding Unicode
	}
}
Invoke-Build $args[0] Mammoth
Invoke-Build $args[0] June
