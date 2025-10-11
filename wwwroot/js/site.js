
$(document).ready(function() {
    // Add fade-in animation to main content
    $('main').addClass('fade-in');
    
    // Auto-hide alerts after 5 seconds
    setTimeout(function() {
        $('.alert').fadeOut('slow');
    }, 5000);
    
    // Add loading spinner to forms on submit
    $('form').on('submit', function() {
        $(this).find('button[type="submit"]').html(
            '<span class="loading"></span> Loading...'
        ).prop('disabled', true);
    });
    
    // Initialize tooltips
    $('[data-toggle="tooltip"]').tooltip();
    
    // Add smooth scrolling to anchor links
    $('a[href*="#"]').on('click', function(e) {
        e.preventDefault();
        
        $('html, body').animate({
            scrollTop: $($(this).attr('href')).offset().top
        }, 500, 'linear');
    });
    
    // Confirm delete actions
    $('.btn-delete').on('click', function(e) {
        if (!confirm('Are you sure you want to delete this item?')) {
            e.preventDefault();
        }
    });
});

// Global functions
function showLoading(element) {
    $(element).html('<span class="loading"></span> Loading...').prop('disabled', true);
}

function hideLoading(element, originalText) {
    $(element).html(originalText).prop('disabled', false);
}

function showMessage(message, type = 'success') {
    const alertClass = `alert-${type}`;
    const alert = $(`
        <div class="alert ${alertClass} alert-dismissible fade show" role="alert">
            ${message}
            <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                <span aria-hidden="true">&times;</span>
            </button>
        </div>
    `);
    
    $('.container').first().prepend(alert);
    
    setTimeout(() => {
        alert.fadeOut();
    }, 5000);
}