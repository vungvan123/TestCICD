pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                sh 'echo "Hello task1"'
            }
        }
        stage('Test') {
            steps {
                echo 'Run some unit tests'
                sh 'echo "Run an integration test"'
            }
        }
        stage('Deploy') {
            steps {
                sh 'echo "Deploy application"'
            }
        }
    }
}
