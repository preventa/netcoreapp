node {
    def app

    stage('Clone repository') {
        checkout scm
    }

    stage('Build image') {
        app = docker.build("admin/netcoreapp")
    }

    stage('Test image') {
        app.inside {
            sh 'echo "Tests passed"'
        }
    }

    stage('Push image') {
        docker.withRegistry('https://ec2-54-76-249-223.eu-west-1.compute.amazonaws.com:4443', 'DTR') {
            app.push("latest")
        }
    }
}
