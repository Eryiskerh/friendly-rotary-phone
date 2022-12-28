pipeline {
    agent any

    stages {
        stage('Restore') {
            steps {
				dotnetRestore project: 'proj.csproj', workDirectory: './lab78/proj/'
			}
		}
		stage('Build') {
            steps {
                dotnetBuild project: 'proj.csproj', workDirectory: './lab78/proj/' 
            }
        }
		stage('Test') {
            steps {
                sh '''mv $( dotnet test --collect:"XPlat Code Coverage" -o TestResults ./lab78/lab78.sln | grep cobertura.xml ) ./lab78/tests/lastlog.cobertura.xml'''
            }
        }
		stage('Publish') {
            steps {
                cobertura autoUpdateHealth: false, autoUpdateStability: false, coberturaReportFile: '**/lastlog.cobertura.xml', conditionalCoverageTargets: '70, 0, 0', failUnhealthy: false, failUnstable: false, lineCoverageTargets: '80, 0, 0', maxNumberOfBuilds: 0, methodCoverageTargets: '80, 0, 0', onlyStable: false, sourceEncoding: 'ASCII', zoomCoverageChart: false
            }
        }
	}
}